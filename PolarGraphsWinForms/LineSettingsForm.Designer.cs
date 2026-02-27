namespace PolarGraphsWinForms
{
    partial class LineSettingsForm
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
            this.apply_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.thickness_label = new System.Windows.Forms.Label();
            this.color_groupBox = new System.Windows.Forms.GroupBox();
            this.red_label = new System.Windows.Forms.Label();
            this.green_label = new System.Windows.Forms.Label();
            this.blue_label = new System.Windows.Forms.Label();
            this.red_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.green_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.thickness_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.color_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // apply_button
            // 
            this.apply_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply_button.Location = new System.Drawing.Point(270, 222);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(145, 53);
            this.apply_button.TabIndex = 0;
            this.apply_button.Text = "Применить";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(453, 222);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(145, 53);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // thickness_label
            // 
            this.thickness_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thickness_label.AutoSize = true;
            this.thickness_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thickness_label.Location = new System.Drawing.Point(265, 13);
            this.thickness_label.Name = "thickness_label";
            this.thickness_label.Size = new System.Drawing.Size(164, 26);
            this.thickness_label.TabIndex = 22;
            this.thickness_label.Text = "Толщина линии";
            // 
            // color_groupBox
            // 
            this.color_groupBox.Controls.Add(this.blue_numericUpDown);
            this.color_groupBox.Controls.Add(this.green_numericUpDown);
            this.color_groupBox.Controls.Add(this.red_numericUpDown);
            this.color_groupBox.Controls.Add(this.blue_label);
            this.color_groupBox.Controls.Add(this.green_label);
            this.color_groupBox.Controls.Add(this.red_label);
            this.color_groupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_groupBox.Location = new System.Drawing.Point(13, 13);
            this.color_groupBox.Name = "color_groupBox";
            this.color_groupBox.Size = new System.Drawing.Size(178, 177);
            this.color_groupBox.TabIndex = 23;
            this.color_groupBox.TabStop = false;
            this.color_groupBox.Text = "Цвет линии";
            // 
            // red_label
            // 
            this.red_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.red_label.AutoSize = true;
            this.red_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.red_label.Location = new System.Drawing.Point(6, 42);
            this.red_label.Name = "red_label";
            this.red_label.Size = new System.Drawing.Size(27, 26);
            this.red_label.TabIndex = 24;
            this.red_label.Text = "R";
            // 
            // green_label
            // 
            this.green_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.green_label.AutoSize = true;
            this.green_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.green_label.Location = new System.Drawing.Point(6, 87);
            this.green_label.Name = "green_label";
            this.green_label.Size = new System.Drawing.Size(28, 26);
            this.green_label.TabIndex = 25;
            this.green_label.Text = "G";
            // 
            // blue_label
            // 
            this.blue_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blue_label.AutoSize = true;
            this.blue_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blue_label.Location = new System.Drawing.Point(6, 132);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(26, 26);
            this.blue_label.TabIndex = 26;
            this.blue_label.Text = "B";
            // 
            // red_numericUpDown
            // 
            this.red_numericUpDown.Location = new System.Drawing.Point(48, 40);
            this.red_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red_numericUpDown.Name = "red_numericUpDown";
            this.red_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.red_numericUpDown.TabIndex = 27;
            // 
            // green_numericUpDown
            // 
            this.green_numericUpDown.Location = new System.Drawing.Point(48, 85);
            this.green_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green_numericUpDown.Name = "green_numericUpDown";
            this.green_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.green_numericUpDown.TabIndex = 28;
            // 
            // blue_numericUpDown
            // 
            this.blue_numericUpDown.Location = new System.Drawing.Point(48, 130);
            this.blue_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue_numericUpDown.Name = "blue_numericUpDown";
            this.blue_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.blue_numericUpDown.TabIndex = 28;
            // 
            // thickness_numericUpDown
            // 
            this.thickness_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thickness_numericUpDown.Location = new System.Drawing.Point(320, 53);
            this.thickness_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.thickness_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thickness_numericUpDown.Name = "thickness_numericUpDown";
            this.thickness_numericUpDown.Size = new System.Drawing.Size(120, 34);
            this.thickness_numericUpDown.TabIndex = 29;
            this.thickness_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LineSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 286);
            this.Controls.Add(this.thickness_numericUpDown);
            this.Controls.Add(this.color_groupBox);
            this.Controls.Add(this.thickness_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.apply_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LineSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LineSettingsForm";
            this.color_groupBox.ResumeLayout(false);
            this.color_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label thickness_label;
        private System.Windows.Forms.GroupBox color_groupBox;
        private System.Windows.Forms.NumericUpDown red_numericUpDown;
        private System.Windows.Forms.Label blue_label;
        private System.Windows.Forms.Label green_label;
        private System.Windows.Forms.Label red_label;
        private System.Windows.Forms.NumericUpDown blue_numericUpDown;
        private System.Windows.Forms.NumericUpDown green_numericUpDown;
        private System.Windows.Forms.NumericUpDown thickness_numericUpDown;
    }
}