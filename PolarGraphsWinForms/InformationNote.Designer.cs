namespace PolarGraphsWinForms
{
    partial class InformationNote
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
            this.info_richTextBox = new System.Windows.Forms.RichTextBox();
            this.info_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_richTextBox
            // 
            this.info_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_richTextBox.BackColor = System.Drawing.Color.White;
            this.info_richTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_richTextBox.Location = new System.Drawing.Point(13, 47);
            this.info_richTextBox.Name = "info_richTextBox";
            this.info_richTextBox.ReadOnly = true;
            this.info_richTextBox.Size = new System.Drawing.Size(743, 352);
            this.info_richTextBox.TabIndex = 0;
            this.info_richTextBox.Text = "";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.Location = new System.Drawing.Point(13, 10);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(99, 26);
            this.info_label.TabIndex = 1;
            this.info_label.Text = "Справка:";
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.Gainsboro;
            this.Close_button.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close_button.Location = new System.Drawing.Point(609, 402);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(147, 47);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // InformationNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(768, 454);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.info_richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationNote";
            this.Text = "InformationNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox info_richTextBox;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button Close_button;
    }
}