using System;
using System.Collections.Generic;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Net;
using AngouriMath;

namespace Kursach_server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            TcpClient clientSocket;
            int counter;

            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started");

            counter = 0;
            while (true)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(" >> " + "Client No:" + Convert.ToString(counter) + " started!");
                ClientHandler client = new ClientHandler();
                client.StartClient(clientSocket, Convert.ToString(counter));
            }
        }
    }

    // Класс методов вычислений (статический)
    public static class Calculation
    {
        // Преобразование AngouriMath.Entity в double
        public static double EntityToDouble(Entity function)
        {
            string strResult = function.ToString(); 
            int slashIndex = strResult.IndexOf('/'); 
            if (slashIndex == -1) 
            {
                return double.Parse(strResult.Replace('.', ',')); 
            }
            string first = strResult.Substring(0, slashIndex); 
            string second = strResult.Substring(slashIndex + 1); 
            double result = double.Parse(first) / double.Parse(second); 
            return result;
        }

        // Вычисление выражения
        public static double Eval(Entity function, double value)
        {
            return EntityToDouble(function.Substitute("x", value).Eval()); 
        }

        // Вычисление первой производной
        public static double D1f(Entity function, double x, double h) 
        {
            return (Eval(function, x + h) - Eval(function, x)) / h;
        }

        // Вычисление второй производной
        public static double D2f(Entity function, double x, double h) 
        {
            return (Eval(function, x + h) - 2 * Eval(function, x) + Eval(function, x - h)) / Math.Pow(h, 2);
        }

        // Вычисление третьей производной
        public static double D3f(Entity function, double x, double h) 
        {
            return (Eval(function, x + 2 * h) - 2 * Eval(function, x + h) + 2 * Eval(function, x - h) - Eval(function, x - 2 * h)) / (2 * Math.Pow(h, 3));
        }

        // Вычисление четвертой производной
        public static double D4f(Entity function, double x, double h)
        {
            return (Eval(function, x + 2 * h) - 4 * Eval(function, x + h) + 6 * Eval(function, x) - 4 * Eval(function, x - h) + Eval(function, x - 2 * h)) / Math.Pow(h, 4);
        }

        // Вычисление производной обычным способом (power - порядок)
        public static double Df(Entity function, double x, int power)
        {
            Entity derivative = function.Derive("x", power); 
            return EntityToDouble(derivative.Substitute("x", x).Eval()); 
        }

        // Определение погрешности вычисления производной
        public static double EpsDf(Entity function, double x, double h, int power, double df)
        {
            Func<Entity, double, double, double> func; 
            switch (power)  
            {
                case 1:
                    func = D1f;
                    break;
                case 2:
                    func = D2f;
                    break;
                case 3:
                    func = D3f;
                    break;
                case 4:
                    func = D4f;
                    break;
                default:
                    func = D1f;
                    break;
            }
            return Math.Abs((func(function, x, h) - df) / df); 
        }
    }

    // Класс - обработчик приложения-клиента
    public class ClientHandler
    {
        TcpClient clientSocket;
        string clNo;

        // Инициализация соединения с клиентом
        public void StartClient(TcpClient inClientSocket, string clineNo)
        {
            clientSocket = inClientSocket;
            clNo = clineNo;
            Thread ctThread = new Thread(Process);
            ctThread.Start();
        }

        // Подключение и обработка данных (основной метод)
        private void Process()
        {
            byte[] bytesFrom = new byte[65536]; 
            int requestCount = 0;

            while (true)
            {
                try
                {
                    requestCount++;
                    NetworkStream networkStream = clientSocket.GetStream(); 
                    Console.WriteLine(" >> ReceiveBufferSize: " + clientSocket.ReceiveBufferSize); 
                    networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize); 
                    string dataFromClient = Encoding.ASCII.GetString(bytesFrom); 
                    string[] values = dataFromClient.Split(new[] { "$$" }, StringSplitOptions.RemoveEmptyEntries); 
                    string function = values[0];
                    double x = double.Parse(values[1]);
                    int a = int.Parse(values[2]);
                    int b = int.Parse(values[3]);
                    Console.WriteLine(" >> " + "From client-" + clNo + ": " + function + ", " + x + ", " + a + ", " + b);

                    string json;

                    try
                    {
                        Entity fn = MathS.FromString(function); 
                        double df1 = Calculation.Df(fn, x, 1); 
                        double df2 = Calculation.Df(fn, x, 2);
                        double df3 = Calculation.Df(fn, x, 3);
                        double df4 = Calculation.Df(fn, x, 4);
                        double h1 = 0, h2 = 0, h3 = 0, h4 = 0; 
                        double minEps1 = double.MaxValue, minEps2 = minEps1, minEps3 = minEps1, minEps4 = minEps1; 
                        List<double> _h = new List<double>(); 
                        List<double> graph1 = new List<double>(); 
                        List<double> graph2 = new List<double>(); 
                        List<double> graph3 = new List<double>(); 
                        List<double> graph4 = new List<double>(); 
                        int hMinPower = a, hMaxPower = b; 
                        for (int hPower = hMinPower; hPower <= hMaxPower; hPower++) 
                        {
                            for (int i = 1; i < 10; i++) 
                            {
                                double h = i * Math.Pow(10, hPower); 
                                double eps1 = Calculation.EpsDf(fn, x, h, 1, df1); 
                                if (eps1 < minEps1) 
                                {
                                    minEps1 = eps1;
                                    h1 = h;
                                }
                                double eps2 = Calculation.EpsDf(fn, x, h, 2, df2); 
                                if (eps2 < minEps2)
                                {
                                    minEps2 = eps2;
                                    h2 = h;
                                }
                                double eps3 = Calculation.EpsDf(fn, x, h, 3, df3);
                                if (eps3 < minEps3)
                                {
                                    minEps3 = eps3;
                                    h3 = h;
                                }
                                double eps4 = Calculation.EpsDf(fn, x, h, 4, df4);
                                if (eps4 < minEps4)
                                {
                                    minEps4 = eps4;
                                    h4 = h;
                                }
                                for (int j = 1; j < 10; j++) 
                                {
                                    double hTmp = h + 0.1 * j * Math.Pow(10, hPower);
                                    _h.Add(hTmp); 
                                    graph1.Add(Calculation.EpsDf(fn, x, hTmp, 1, df1)); 
                                    graph2.Add(Calculation.EpsDf(fn, x, hTmp, 2, df2));
                                    graph3.Add(Calculation.EpsDf(fn, x, hTmp, 3, df3));
                                    graph4.Add(Calculation.EpsDf(fn, x, hTmp, 4, df4));
                                }
                            }
                        }
                        double[] hArray = new[] { h1, h2, h3, h4 }; 
                        double[] eArray = new[] { minEps1, minEps2, minEps3, minEps4 };
                        double[] derivatives = new[] { Calculation.D1f(fn, x, h1), Calculation.D2f(fn, x, h2), Calculation.D3f(fn, x, h3), Calculation.D4f(fn, x, h4) }; // вычисляем производные с заданным шагом дискретизации с помощью формул численного дифференцирования

                        json = "{\"h\":" + JsonSerializer.Serialize(hArray) + ","; 
                        json += "\"d\":" + JsonSerializer.Serialize(derivatives) + ",";
                        json += "\"e\":" + JsonSerializer.Serialize(eArray) + ",";
                        json += "\"x\":" + JsonSerializer.Serialize(_h) + ",";
                        json += "\"y1\":" + JsonSerializer.Serialize(graph1.ToArray()) + ",";
                        json += "\"y2\":" + JsonSerializer.Serialize(graph2.ToArray()) + ",";
                        json += "\"y3\":" + JsonSerializer.Serialize(graph3.ToArray()) + ",";
                        json += "\"y4\":" + JsonSerializer.Serialize(graph4.ToArray());
                        json += "}";

                    }
                    catch (Exception e)
                    {
                        json = e.Message; 
                    }
                    byte[] sendBytes = Encoding.ASCII.GetBytes(json); 
                    networkStream.Write(sendBytes, 0, sendBytes.Length); 
                    networkStream.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}
