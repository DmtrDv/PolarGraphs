namespace PolarGraphsWinForms
{
    partial class SettingsForm
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
            this.Close_button = new System.Windows.Forms.Button();
            this.DarkMode_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Close_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close_button.Location = new System.Drawing.Point(404, 175);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(147, 47);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // DarkMode_checkBox
            // 
            this.DarkMode_checkBox.AutoSize = true;
            this.DarkMode_checkBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DarkMode_checkBox.Location = new System.Drawing.Point(12, 21);
            this.DarkMode_checkBox.Name = "DarkMode_checkBox";
            this.DarkMode_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DarkMode_checkBox.Size = new System.Drawing.Size(157, 30);
            this.DarkMode_checkBox.TabIndex = 4;
            this.DarkMode_checkBox.Text = "Тёмная тема";
            this.DarkMode_checkBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 234);
            this.Controls.Add(this.DarkMode_checkBox);
            this.Controls.Add(this.Close_button);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.CheckBox DarkMode_checkBox;
    }
}