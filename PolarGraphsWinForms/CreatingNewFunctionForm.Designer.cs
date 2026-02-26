namespace PolarGraphsWinForms
{
    partial class CreatingNewFunctionForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphTab_tabControl = new System.Windows.Forms.TabControl();
            this.polarGraph_tabPage = new System.Windows.Forms.TabPage();
            this.polarGraph_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.сartesianGraph_tabPage = new System.Windows.Forms.TabPage();
            this.сartesianGraph_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.parameters_groupBox = new System.Windows.Forms.GroupBox();
            this.function_textBox = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoRightInput_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StartСorner_label = new System.Windows.Forms.Label();
            this.EndСorner_label = new System.Windows.Forms.Label();
            this.Step_label = new System.Windows.Forms.Label();
            this.startСorner_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endСorner_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.step_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.build_button = new System.Windows.Forms.Button();
            this.addons_button = new System.Windows.Forms.Button();
            this.graphTab_tabControl.SuspendLayout();
            this.polarGraph_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polarGraph_chart)).BeginInit();
            this.сartesianGraph_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сartesianGraph_chart)).BeginInit();
            this.parameters_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startСorner_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endСorner_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // graphTab_tabControl
            // 
            this.graphTab_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphTab_tabControl.Controls.Add(this.polarGraph_tabPage);
            this.graphTab_tabControl.Controls.Add(this.сartesianGraph_tabPage);
            this.graphTab_tabControl.Location = new System.Drawing.Point(12, 12);
            this.graphTab_tabControl.Name = "graphTab_tabControl";
            this.graphTab_tabControl.SelectedIndex = 0;
            this.graphTab_tabControl.Size = new System.Drawing.Size(928, 659);
            this.graphTab_tabControl.TabIndex = 16;
            // 
            // polarGraph_tabPage
            // 
            this.polarGraph_tabPage.Controls.Add(this.polarGraph_chart);
            this.polarGraph_tabPage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polarGraph_tabPage.Location = new System.Drawing.Point(4, 25);
            this.polarGraph_tabPage.Name = "polarGraph_tabPage";
            this.polarGraph_tabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.polarGraph_tabPage.Size = new System.Drawing.Size(920, 630);
            this.polarGraph_tabPage.TabIndex = 0;
            this.polarGraph_tabPage.Text = "Полярный график";
            this.polarGraph_tabPage.UseVisualStyleBackColor = true;
            // 
            // polarGraph_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.polarGraph_chart.ChartAreas.Add(chartArea1);
            this.polarGraph_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polarGraph_chart.Location = new System.Drawing.Point(3, 3);
            this.polarGraph_chart.Name = "polarGraph_chart";
            this.polarGraph_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series1.Name = "Series1";
            this.polarGraph_chart.Series.Add(series1);
            this.polarGraph_chart.Size = new System.Drawing.Size(914, 624);
            this.polarGraph_chart.TabIndex = 0;
            this.polarGraph_chart.Text = "chart1";
            // 
            // сartesianGraph_tabPage
            // 
            this.сartesianGraph_tabPage.Controls.Add(this.сartesianGraph_chart);
            this.сartesianGraph_tabPage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сartesianGraph_tabPage.Location = new System.Drawing.Point(4, 25);
            this.сartesianGraph_tabPage.Name = "сartesianGraph_tabPage";
            this.сartesianGraph_tabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.сartesianGraph_tabPage.Size = new System.Drawing.Size(920, 630);
            this.сartesianGraph_tabPage.TabIndex = 1;
            this.сartesianGraph_tabPage.Text = "Декартовый график";
            this.сartesianGraph_tabPage.UseVisualStyleBackColor = true;
            // 
            // сartesianGraph_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.сartesianGraph_chart.ChartAreas.Add(chartArea2);
            this.сartesianGraph_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сartesianGraph_chart.Location = new System.Drawing.Point(3, 3);
            this.сartesianGraph_chart.Name = "сartesianGraph_chart";
            this.сartesianGraph_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.сartesianGraph_chart.Series.Add(series2);
            this.сartesianGraph_chart.Size = new System.Drawing.Size(914, 624);
            this.сartesianGraph_chart.TabIndex = 10;
            this.сartesianGraph_chart.Text = "chart1";
            // 
            // parameters_groupBox
            // 
            this.parameters_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parameters_groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.parameters_groupBox.Controls.Add(this.step_numericUpDown);
            this.parameters_groupBox.Controls.Add(this.endСorner_numericUpDown);
            this.parameters_groupBox.Controls.Add(this.startСorner_numericUpDown);
            this.parameters_groupBox.Controls.Add(this.Step_label);
            this.parameters_groupBox.Controls.Add(this.EndСorner_label);
            this.parameters_groupBox.Controls.Add(this.StartСorner_label);
            this.parameters_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parameters_groupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parameters_groupBox.ForeColor = System.Drawing.Color.Black;
            this.parameters_groupBox.Location = new System.Drawing.Point(959, 139);
            this.parameters_groupBox.Name = "parameters_groupBox";
            this.parameters_groupBox.Size = new System.Drawing.Size(349, 184);
            this.parameters_groupBox.TabIndex = 18;
            this.parameters_groupBox.TabStop = false;
            this.parameters_groupBox.Text = "Параметры";
            // 
            // function_textBox
            // 
            this.function_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.function_textBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.function_textBox.Location = new System.Drawing.Point(959, 67);
            this.function_textBox.Multiline = true;
            this.function_textBox.Name = "function_textBox";
            this.function_textBox.Size = new System.Drawing.Size(503, 58);
            this.function_textBox.TabIndex = 19;
            // 
            // Input_label
            // 
            this.Input_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_label.AutoSize = true;
            this.Input_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_label.Location = new System.Drawing.Point(954, 37);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(210, 26);
            this.Input_label.TabIndex = 20;
            this.Input_label.Text = "Ввод функции r(θ) =";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1438, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "?";
            this.infoRightInput_toolTip.SetToolTip(this.label2, "Информация:\r\n");
            // 
            // StartСorner_label
            // 
            this.StartСorner_label.AutoSize = true;
            this.StartСorner_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartСorner_label.Location = new System.Drawing.Point(6, 50);
            this.StartСorner_label.Name = "StartСorner_label";
            this.StartСorner_label.Size = new System.Drawing.Size(185, 26);
            this.StartСorner_label.TabIndex = 22;
            this.StartСorner_label.Text = "Начальный угол =";
            // 
            // EndСorner_label
            // 
            this.EndСorner_label.AutoSize = true;
            this.EndСorner_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndСorner_label.Location = new System.Drawing.Point(14, 95);
            this.EndСorner_label.Name = "EndСorner_label";
            this.EndСorner_label.Size = new System.Drawing.Size(177, 26);
            this.EndСorner_label.TabIndex = 23;
            this.EndСorner_label.Text = "Конечный угол =";
            // 
            // Step_label
            // 
            this.Step_label.AutoSize = true;
            this.Step_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step_label.Location = new System.Drawing.Point(120, 140);
            this.Step_label.Name = "Step_label";
            this.Step_label.Size = new System.Drawing.Size(71, 26);
            this.Step_label.TabIndex = 24;
            this.Step_label.Text = "Шаг =";
            // 
            // startСorner_numericUpDown
            // 
            this.startСorner_numericUpDown.DecimalPlaces = 2;
            this.startСorner_numericUpDown.Location = new System.Drawing.Point(197, 45);
            this.startСorner_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.startСorner_numericUpDown.Name = "startСorner_numericUpDown";
            this.startСorner_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.startСorner_numericUpDown.TabIndex = 25;
            // 
            // endСorner_numericUpDown
            // 
            this.endСorner_numericUpDown.DecimalPlaces = 2;
            this.endСorner_numericUpDown.Location = new System.Drawing.Point(197, 90);
            this.endСorner_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.endСorner_numericUpDown.Name = "endСorner_numericUpDown";
            this.endСorner_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.endСorner_numericUpDown.TabIndex = 26;
            this.endСorner_numericUpDown.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // step_numericUpDown
            // 
            this.step_numericUpDown.DecimalPlaces = 2;
            this.step_numericUpDown.Location = new System.Drawing.Point(197, 135);
            this.step_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.step_numericUpDown.Name = "step_numericUpDown";
            this.step_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.step_numericUpDown.TabIndex = 27;
            this.step_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // build_button
            // 
            this.build_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.build_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.build_button.Location = new System.Drawing.Point(1280, 614);
            this.build_button.Name = "build_button";
            this.build_button.Size = new System.Drawing.Size(182, 50);
            this.build_button.TabIndex = 22;
            this.build_button.Text = "Построить";
            this.build_button.UseVisualStyleBackColor = true;
            this.build_button.Click += new System.EventHandler(this.build_button_Click);
            // 
            // addons_button
            // 
            this.addons_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addons_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addons_button.Location = new System.Drawing.Point(959, 614);
            this.addons_button.Name = "addons_button";
            this.addons_button.Size = new System.Drawing.Size(182, 50);
            this.addons_button.TabIndex = 23;
            this.addons_button.Text = "Надстройки";
            this.addons_button.UseVisualStyleBackColor = true;
            // 
            // CreatingNewFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 683);
            this.Controls.Add(this.addons_button);
            this.Controls.Add(this.build_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.function_textBox);
            this.Controls.Add(this.parameters_groupBox);
            this.Controls.Add(this.graphTab_tabControl);
            this.Name = "CreatingNewFunctionForm";
            this.Tag = "";
            this.Text = "CreatingNewFunctionForm";
            this.graphTab_tabControl.ResumeLayout(false);
            this.polarGraph_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polarGraph_chart)).EndInit();
            this.сartesianGraph_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.сartesianGraph_chart)).EndInit();
            this.parameters_groupBox.ResumeLayout(false);
            this.parameters_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startСorner_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endСorner_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl graphTab_tabControl;
        private System.Windows.Forms.TabPage polarGraph_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart polarGraph_chart;
        private System.Windows.Forms.TabPage сartesianGraph_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart сartesianGraph_chart;
        private System.Windows.Forms.GroupBox parameters_groupBox;
        private System.Windows.Forms.TextBox function_textBox;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip infoRightInput_toolTip;
        private System.Windows.Forms.Label StartСorner_label;
        private System.Windows.Forms.Label EndСorner_label;
        private System.Windows.Forms.Label Step_label;
        private System.Windows.Forms.NumericUpDown step_numericUpDown;
        private System.Windows.Forms.NumericUpDown endСorner_numericUpDown;
        private System.Windows.Forms.NumericUpDown startСorner_numericUpDown;
        private System.Windows.Forms.Button build_button;
        private System.Windows.Forms.Button addons_button;
    }
}