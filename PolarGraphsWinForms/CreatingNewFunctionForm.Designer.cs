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
            this.сartesianGraph_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.parameters_groupBox = new System.Windows.Forms.GroupBox();
            this.step_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endСorner_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startСorner_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Step_label = new System.Windows.Forms.Label();
            this.EndСorner_label = new System.Windows.Forms.Label();
            this.StartСorner_label = new System.Windows.Forms.Label();
            this.function_textBox = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoRightInput_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.build_button = new System.Windows.Forms.Button();
            this.addons_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.сartesianGraph_chart)).BeginInit();
            this.parameters_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endСorner_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startСorner_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // сartesianGraph_chart
            // 
            this.сartesianGraph_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.сartesianGraph_chart.ChartAreas.Add(chartArea1);
            this.сartesianGraph_chart.Location = new System.Drawing.Point(8, 6);
            this.сartesianGraph_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.сartesianGraph_chart.Name = "сartesianGraph_chart";
            this.сartesianGraph_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.сartesianGraph_chart.Series.Add(series1);
            this.сartesianGraph_chart.Size = new System.Drawing.Size(790, 750);
            this.сartesianGraph_chart.TabIndex = 10;
            this.сartesianGraph_chart.Text = "chart1";
            // 
            // parameters_groupBox
            // 
            this.parameters_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.parameters_groupBox.Location = new System.Drawing.Point(5, 130);
            this.parameters_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameters_groupBox.Name = "parameters_groupBox";
            this.parameters_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameters_groupBox.Size = new System.Drawing.Size(349, 185);
            this.parameters_groupBox.TabIndex = 18;
            this.parameters_groupBox.TabStop = false;
            this.parameters_groupBox.Text = "Параметры";
            // 
            // step_numericUpDown
            // 
            this.step_numericUpDown.DecimalPlaces = 2;
            this.step_numericUpDown.Location = new System.Drawing.Point(210, 135);
            this.step_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // endСorner_numericUpDown
            // 
            this.endСorner_numericUpDown.DecimalPlaces = 2;
            this.endСorner_numericUpDown.Location = new System.Drawing.Point(210, 90);
            this.endСorner_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // startСorner_numericUpDown
            // 
            this.startСorner_numericUpDown.DecimalPlaces = 2;
            this.startСorner_numericUpDown.Location = new System.Drawing.Point(210, 46);
            this.startСorner_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startСorner_numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.startСorner_numericUpDown.Name = "startСorner_numericUpDown";
            this.startСorner_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.startСorner_numericUpDown.TabIndex = 25;
            // 
            // Step_label
            // 
            this.Step_label.AutoSize = true;
            this.Step_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Step_label.Location = new System.Drawing.Point(13, 137);
            this.Step_label.Name = "Step_label";
            this.Step_label.Size = new System.Drawing.Size(58, 26);
            this.Step_label.TabIndex = 24;
            this.Step_label.Text = "Шаг:";
            // 
            // EndСorner_label
            // 
            this.EndСorner_label.AutoSize = true;
            this.EndСorner_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndСorner_label.Location = new System.Drawing.Point(13, 92);
            this.EndСorner_label.Name = "EndСorner_label";
            this.EndСorner_label.Size = new System.Drawing.Size(164, 26);
            this.EndСorner_label.TabIndex = 23;
            this.EndСorner_label.Text = "Конечный угол:";
            // 
            // StartСorner_label
            // 
            this.StartСorner_label.AutoSize = true;
            this.StartСorner_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartСorner_label.Location = new System.Drawing.Point(13, 48);
            this.StartСorner_label.Name = "StartСorner_label";
            this.StartСorner_label.Size = new System.Drawing.Size(172, 26);
            this.StartСorner_label.TabIndex = 22;
            this.StartСorner_label.Text = "Начальный угол:";
            // 
            // function_textBox
            // 
            this.function_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.function_textBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.function_textBox.Location = new System.Drawing.Point(6, 58);
            this.function_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.function_textBox.Multiline = true;
            this.function_textBox.Name = "function_textBox";
            this.function_textBox.Size = new System.Drawing.Size(503, 58);
            this.function_textBox.TabIndex = 19;
            // 
            // Input_label
            // 
            this.Input_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_label.AutoSize = true;
            this.Input_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_label.Location = new System.Drawing.Point(2, 29);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(213, 26);
            this.Input_label.TabIndex = 20;
            this.Input_label.Text = "Ввод функции r(fi) =";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(482, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "?";
            this.infoRightInput_toolTip.SetToolTip(this.label2, "Информация:\r\n");
            // 
            // build_button
            // 
            this.build_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.build_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.build_button.Location = new System.Drawing.Point(327, 704);
            this.build_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.build_button.Name = "build_button";
            this.build_button.Size = new System.Drawing.Size(181, 50);
            this.build_button.TabIndex = 22;
            this.build_button.Text = "Построить";
            this.build_button.UseVisualStyleBackColor = true;
            this.build_button.Click += new System.EventHandler(this.build_button_Click);
            // 
            // addons_button
            // 
            this.addons_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addons_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addons_button.Location = new System.Drawing.Point(6, 674);
            this.addons_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addons_button.Name = "addons_button";
            this.addons_button.Size = new System.Drawing.Size(181, 50);
            this.addons_button.TabIndex = 23;
            this.addons_button.Text = "Надстройки";
            this.addons_button.UseVisualStyleBackColor = true;
            this.addons_button.Click += new System.EventHandler(this.addons_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.сartesianGraph_chart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.function_textBox);
            this.splitContainer1.Panel2.Controls.Add(this.parameters_groupBox);
            this.splitContainer1.Panel2.Controls.Add(this.addons_button);
            this.splitContainer1.Panel2.Controls.Add(this.build_button);
            this.splitContainer1.Panel2.Controls.Add(this.Input_label);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 762);
            this.splitContainer1.SplitterDistance = 796;
            this.splitContainer1.TabIndex = 24;
            // 
            // CreatingNewFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 762);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatingNewFunctionForm";
            this.Tag = "";
            this.Text = "CreatingNewFunctionForm";
            ((System.ComponentModel.ISupportInitialize)(this.сartesianGraph_chart)).EndInit();
            this.parameters_groupBox.ResumeLayout(false);
            this.parameters_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endСorner_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startСorner_numericUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}