using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace kursach_client
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintStatus("Клиент запущен");
            try
            {
                clientSocket.Connect("127.0.0.1", 8888);
                PrintStatus("Установлено соединение с сервером");
            }
            catch (Exception exc)
            {
                PrintError(exc.Message);
            }
        }

        // Обработчик клика на кнопку "вычислить"
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream serverStream = clientSocket.GetStream(); 
                string functionString = function_textBox.Text; 
                string x = x_textBox.Text;
                string a = a_textBox.Text;
                string b = b_textBox.Text;
                if (functionString == "" || x == "" || a == "" || b == "") 
                {
                    PrintError("Имеются незаполненные поля."); 
                    return;
                }
                PrintStatus("Выполняются вычисления. Пожалуйста, подождите..."); 
                string outString = string.Join("$$", new[] { functionString, x, a, b, "" }); 
                byte[] outStream = Encoding.ASCII.GetBytes(outString);
                serverStream.Write(outStream, 0, outStream.Length); 

                serverStream.Flush();

                byte[] inStream = new byte[65536]; 
                serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize); 
                string responseString = Encoding.ASCII.GetString(inStream); 
                int stringEndIndex = responseString.IndexOf('\0'); 
                if (stringEndIndex >= 0) 
                    responseString = responseString.Substring(0, stringEndIndex); 

                ResponseData response;
                try
                {
                    response = JsonSerializer.Deserialize<ResponseData>(responseString); 
                    Chart[] charts = new[] { chart1, chart2, chart3, chart4 }; 
                    for (int i = 0; i < charts.Length; i++) 
                    {
                        Chart chart = charts[i];
                        chart.Series[0].Points.Clear(); 
                        chart.Series[0].ChartType = SeriesChartType.Line; 
                        chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; 
                        chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        chart.ChartAreas[0].AxisX.Crossing = 0;
                        chart.ChartAreas[0].AxisY.Crossing = 0;
                        chart.ChartAreas[0].AxisX.Maximum = response.h[i] * 10; 
                        chart.ChartAreas[0].AxisY.Maximum = response.e[i] * 100;
                        chart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.###E-0}";
                    }
                    for (int i = 0; i < response.x.Length; ++i) 
                    {
                        chart1.Series[0].Points.AddXY(response.x[i], response.y1[i]);
                        chart2.Series[0].Points.AddXY(response.x[i], response.y2[i]);
                        chart3.Series[0].Points.AddXY(response.x[i], response.y3[i]);
                        chart4.Series[0].Points.AddXY(response.x[i], response.y4[i]);
                    }
                    hResult_textBox.Lines = response.h.Select(Convert.ToString).ToArray(); 
                    derivativesResult_textBox.Lines = response.d.Select(Convert.ToString).ToArray(); 
                    PrintStatus("Завершено");
                }
                catch
                {
                    PrintError(responseString); 
                }
            } 
            catch(Exception exc)
            {
                PrintError(exc.Message); 
            }
        }

        // Вывод состояния операции
        public void PrintStatus(string message)
        {
            status_label.ForeColor = Color.Black;
            status_label.Text = message;
            status_label.Update();
        }

        // Вывод сообщения об ошибке
        public void PrintError(string message)
        {
            PrintStatus("Ошибка: " + message);
            status_label.ForeColor = Color.Red;
        }
    }

    // Вспомогательный класс для десериализации JSON объекта в объект C#
    public class ResponseData
    {
        public double[] h { get; set; }
        public double[] e { get; set; }
        public double[] d { get; set; }
        public double[] x { get; set; }
        public double[] y1 { get; set; }
        public double[] y2 { get; set; }
        public double[] y3 { get; set; }
        public double[] y4 { get; set; }
    }
}
