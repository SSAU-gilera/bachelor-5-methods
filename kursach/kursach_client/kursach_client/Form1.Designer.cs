namespace kursach_client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.function_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.a_textBox = new System.Windows.Forms.TextBox();
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.function_label = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.b_label = new System.Windows.Forms.Label();
            this.b_textBox = new System.Windows.Forms.TextBox();
            this.h_label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hResult_textBox = new System.Windows.Forms.TextBox();
            this.derivativesResult_textBox = new System.Windows.Forms.TextBox();
            this.hResult_label = new System.Windows.Forms.Label();
            this.derivativesResult_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // function_textBox
            // 
            this.function_textBox.Location = new System.Drawing.Point(60, 12);
            this.function_textBox.Name = "function_textBox";
            this.function_textBox.Size = new System.Drawing.Size(306, 22);
            this.function_textBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(14, 621);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(79, 17);
            this.status_label.TabIndex = 2;
            this.status_label.Text = "Состояние";
            // 
            // a_textBox
            // 
            this.a_textBox.Location = new System.Drawing.Point(60, 88);
            this.a_textBox.Name = "a_textBox";
            this.a_textBox.Size = new System.Drawing.Size(100, 22);
            this.a_textBox.TabIndex = 3;
            // 
            // x_textBox
            // 
            this.x_textBox.Location = new System.Drawing.Point(60, 128);
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.Size = new System.Drawing.Size(100, 22);
            this.x_textBox.TabIndex = 4;
            // 
            // function_label
            // 
            this.function_label.AutoSize = true;
            this.function_label.Location = new System.Drawing.Point(14, 15);
            this.function_label.Name = "function_label";
            this.function_label.Size = new System.Drawing.Size(40, 17);
            this.function_label.TabIndex = 5;
            this.function_label.Text = "f(x) =";
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(26, 91);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(31, 17);
            this.a_label.TabIndex = 6;
            this.a_label.Text = "10^";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(28, 131);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(26, 17);
            this.x_label.TabIndex = 7;
            this.x_label.Text = "x =";
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.Location = new System.Drawing.Point(168, 91);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(64, 17);
            this.b_label.TabIndex = 8;
            this.b_label.Text = "до 9*10^";
            // 
            // b_textBox
            // 
            this.b_textBox.Location = new System.Drawing.Point(238, 88);
            this.b_textBox.Name = "b_textBox";
            this.b_textBox.Size = new System.Drawing.Size(100, 22);
            this.b_textBox.TabIndex = 9;
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Location = new System.Drawing.Point(14, 59);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(222, 17);
            this.h_label.TabIndex = 10;
            this.h_label.Text = "Шаг h изменяется в пределах от";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(398, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(356, 296);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(760, 12);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(356, 296);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(398, 314);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(356, 296);
            this.chart3.TabIndex = 13;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea8.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart4.Legends.Add(legend8);
            this.chart4.Location = new System.Drawing.Point(760, 314);
            this.chart4.Name = "chart4";
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart4.Series.Add(series8);
            this.chart4.Size = new System.Drawing.Size(356, 296);
            this.chart4.TabIndex = 14;
            this.chart4.Text = "chart4";
            // 
            // hResult_textBox
            // 
            this.hResult_textBox.Location = new System.Drawing.Point(17, 226);
            this.hResult_textBox.Multiline = true;
            this.hResult_textBox.Name = "hResult_textBox";
            this.hResult_textBox.ReadOnly = true;
            this.hResult_textBox.Size = new System.Drawing.Size(349, 138);
            this.hResult_textBox.TabIndex = 15;
            // 
            // derivativesResult_textBox
            // 
            this.derivativesResult_textBox.Location = new System.Drawing.Point(17, 389);
            this.derivativesResult_textBox.Multiline = true;
            this.derivativesResult_textBox.Name = "derivativesResult_textBox";
            this.derivativesResult_textBox.ReadOnly = true;
            this.derivativesResult_textBox.Size = new System.Drawing.Size(349, 138);
            this.derivativesResult_textBox.TabIndex = 16;
            // 
            // hResult_label
            // 
            this.hResult_label.AutoSize = true;
            this.hResult_label.Location = new System.Drawing.Point(17, 203);
            this.hResult_label.Name = "hResult_label";
            this.hResult_label.Size = new System.Drawing.Size(53, 17);
            this.hResult_label.TabIndex = 17;
            this.hResult_label.Text = "h1 - h4";
            // 
            // derivativesResult_label
            // 
            this.derivativesResult_label.AutoSize = true;
            this.derivativesResult_label.Location = new System.Drawing.Point(17, 366);
            this.derivativesResult_label.Name = "derivativesResult_label";
            this.derivativesResult_label.Size = new System.Drawing.Size(61, 17);
            this.derivativesResult_label.TabIndex = 18;
            this.derivativesResult_label.Text = "d1f - d4f";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 647);
            this.Controls.Add(this.derivativesResult_label);
            this.Controls.Add(this.hResult_label);
            this.Controls.Add(this.derivativesResult_textBox);
            this.Controls.Add(this.hResult_textBox);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.b_textBox);
            this.Controls.Add(this.b_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.a_label);
            this.Controls.Add(this.function_label);
            this.Controls.Add(this.x_textBox);
            this.Controls.Add(this.a_textBox);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.function_textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1144, 694);
            this.MinimumSize = new System.Drawing.Size(1144, 694);
            this.Name = "Form1";
            this.Text = "Численное дифференцирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox function_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.TextBox a_textBox;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.Label function_label;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.TextBox b_textBox;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.TextBox hResult_textBox;
        private System.Windows.Forms.TextBox derivativesResult_textBox;
        private System.Windows.Forms.Label hResult_label;
        private System.Windows.Forms.Label derivativesResult_label;
    }
}

