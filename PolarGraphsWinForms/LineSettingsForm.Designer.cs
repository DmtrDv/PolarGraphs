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
            this.thickness_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorDialog_pictureBox = new System.Windows.Forms.PictureBox();
            this.colorLine_colorDialog = new System.Windows.Forms.ColorDialog();
            this.color_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDialog_pictureBox)).BeginInit();
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
            this.color_groupBox.Controls.Add(this.colorDialog_pictureBox);
            this.color_groupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color_groupBox.Location = new System.Drawing.Point(13, 13);
            this.color_groupBox.Name = "color_groupBox";
            this.color_groupBox.Size = new System.Drawing.Size(182, 186);
            this.color_groupBox.TabIndex = 23;
            this.color_groupBox.TabStop = false;
            this.color_groupBox.Text = "Цвет линии";
            // 
            // thickness_numericUpDown
            // 
            this.thickness_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thickness_numericUpDown.Location = new System.Drawing.Point(275, 52);
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
            // colorDialog_pictureBox
            // 
            this.colorDialog_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorDialog_pictureBox.Location = new System.Drawing.Point(5, 26);
            this.colorDialog_pictureBox.Name = "colorDialog_pictureBox";
            this.colorDialog_pictureBox.Size = new System.Drawing.Size(170, 150);
            this.colorDialog_pictureBox.TabIndex = 30;
            this.colorDialog_pictureBox.TabStop = false;
            this.colorDialog_pictureBox.Click += new System.EventHandler(this.colorDialog_pictureBox_Click);
            // 
            // colorLine_colorDialog
            // 
            this.colorLine_colorDialog.FullOpen = true;
            // 
            // LineSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.Load += new System.EventHandler(this.LineSettingsForm_Load);
            this.color_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thickness_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDialog_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label thickness_label;
        private System.Windows.Forms.GroupBox color_groupBox;
        private System.Windows.Forms.NumericUpDown thickness_numericUpDown;
        private System.Windows.Forms.PictureBox colorDialog_pictureBox;
        private System.Windows.Forms.ColorDialog colorLine_colorDialog;
    }
}