using System.Drawing;

namespace PolarGraphsWinForms
{
    partial class astroida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CreateGraph_button = new System.Windows.Forms.Button();
            this.a_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountPoints_textBox = new System.Windows.Forms.TextBox();
            this.Start_fi_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.End_fi_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CosValue_textBox = new System.Windows.Forms.TextBox();
            this.SinValue_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateGraph_button
            // 
            this.CreateGraph_button.Location = new System.Drawing.Point(1149, 702);
            this.CreateGraph_button.Name = "CreateGraph_button";
            this.CreateGraph_button.Size = new System.Drawing.Size(155, 45);
            this.CreateGraph_button.TabIndex = 1;
            this.CreateGraph_button.Text = "Построить";
            this.CreateGraph_button.UseVisualStyleBackColor = true;
            this.CreateGraph_button.Click += new System.EventHandler(this.CreateGraph_button_Click);
            // 
            // a_textBox
            // 
            this.a_textBox.Location = new System.Drawing.Point(1096, 91);
            this.a_textBox.Name = "a_textBox";
            this.a_textBox.Size = new System.Drawing.Size(103, 22);
            this.a_textBox.TabIndex = 2;
            this.a_textBox.Text = "1";
            this.a_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1016, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радиус (a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(964, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество точек";
            // 
            // CountPoints_textBox
            // 
            this.CountPoints_textBox.Location = new System.Drawing.Point(1096, 119);
            this.CountPoints_textBox.Name = "CountPoints_textBox";
            this.CountPoints_textBox.Size = new System.Drawing.Size(103, 22);
            this.CountPoints_textBox.TabIndex = 5;
            this.CountPoints_textBox.Text = "100";
            this.CountPoints_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Start_fi_textBox
            // 
            this.Start_fi_textBox.Location = new System.Drawing.Point(1096, 147);
            this.Start_fi_textBox.Name = "Start_fi_textBox";
            this.Start_fi_textBox.Size = new System.Drawing.Size(103, 22);
            this.Start_fi_textBox.TabIndex = 7;
            this.Start_fi_textBox.Text = "0";
            this.Start_fi_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Начальный угол";
            // 
            // End_fi_textBox
            // 
            this.End_fi_textBox.Location = new System.Drawing.Point(1096, 175);
            this.End_fi_textBox.Name = "End_fi_textBox";
            this.End_fi_textBox.Size = new System.Drawing.Size(103, 22);
            this.End_fi_textBox.TabIndex = 9;
            this.End_fi_textBox.Text = "360";
            this.End_fi_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Конечный угол";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(914, 621);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // CosValue_textBox
            // 
            this.CosValue_textBox.Location = new System.Drawing.Point(1096, 203);
            this.CosValue_textBox.Name = "CosValue_textBox";
            this.CosValue_textBox.Size = new System.Drawing.Size(103, 22);
            this.CosValue_textBox.TabIndex = 11;
            this.CosValue_textBox.Text = "1";
            this.CosValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SinValue_textBox
            // 
            this.SinValue_textBox.Location = new System.Drawing.Point(1096, 231);
            this.SinValue_textBox.Name = "SinValue_textBox";
            this.SinValue_textBox.Size = new System.Drawing.Size(103, 22);
            this.SinValue_textBox.TabIndex = 12;
            this.SinValue_textBox.Text = "1";
            this.SinValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1059, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1059, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "SIn";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 656);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(964, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Параметры:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(964, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Формула функции:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 18;
            this.button1.Text = "Надстройки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(914, 621);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // astroida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 806);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SinValue_textBox);
            this.Controls.Add(this.CosValue_textBox);
            this.Controls.Add(this.End_fi_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start_fi_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountPoints_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a_textBox);
            this.Controls.Add(this.CreateGraph_button);
            this.Name = "astroida";
            this.Text = "astroida";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateGraph_button;
        private System.Windows.Forms.TextBox a_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountPoints_textBox;
        private System.Windows.Forms.TextBox Start_fi_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox End_fi_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox CosValue_textBox;
        private System.Windows.Forms.TextBox SinValue_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}