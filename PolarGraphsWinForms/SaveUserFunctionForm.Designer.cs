namespace PolarGraphsWinForms
{
    partial class SaveUserFunctionForm
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.save_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.function_label = new System.Windows.Forms.Label();
            this.function_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(191, 85);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(333, 34);
            this.name_textBox.TabIndex = 0;
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.Location = new System.Drawing.Point(12, 24);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(217, 26);
            this.save_label.TabIndex = 1;
            this.save_label.Text = "Сохранение функции";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(24, 88);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(159, 26);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Наименование:";
            // 
            // function_label
            // 
            this.function_label.AutoSize = true;
            this.function_label.Location = new System.Drawing.Point(77, 129);
            this.function_label.Name = "function_label";
            this.function_label.Size = new System.Drawing.Size(105, 26);
            this.function_label.TabIndex = 4;
            this.function_label.Text = "Функция:";
            // 
            // function_richTextBox
            // 
            this.function_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_richTextBox.Location = new System.Drawing.Point(191, 127);
            this.function_richTextBox.Name = "function_richTextBox";
            this.function_richTextBox.ReadOnly = true;
            this.function_richTextBox.Size = new System.Drawing.Size(333, 57);
            this.function_richTextBox.TabIndex = 5;
            this.function_richTextBox.Text = "";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(191, 191);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(154, 50);
            this.Save_button.TabIndex = 13;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(372, 191);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(154, 50);
            this.Cancel_button.TabIndex = 14;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // SaveUserFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(538, 250);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.function_richTextBox);
            this.Controls.Add(this.function_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.name_textBox);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SaveUserFunctionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveUserFunctionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label save_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label function_label;
        private System.Windows.Forms.RichTextBox function_richTextBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}