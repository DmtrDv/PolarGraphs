namespace PolarGraphsWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main_toolStrip = new System.Windows.Forms.ToolStrip();
            this.FunctionList_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.work_panel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportIn_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFunction_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoNote_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSession_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_toolStrip
            // 
            this.main_toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_toolStrip.AutoSize = false;
            this.main_toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.main_toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.main_toolStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.main_toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.main_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FunctionList_toolStripComboBox});
            this.main_toolStrip.Location = new System.Drawing.Point(16, 30);
            this.main_toolStrip.Name = "main_toolStrip";
            this.main_toolStrip.Size = new System.Drawing.Size(1326, 32);
            this.main_toolStrip.TabIndex = 0;
            this.main_toolStrip.Text = "toolStrip1";
            // 
            // FunctionList_toolStripComboBox
            // 
            this.FunctionList_toolStripComboBox.AccessibleName = "";
            this.FunctionList_toolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunctionList_toolStripComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionList_toolStripComboBox.Name = "FunctionList_toolStripComboBox";
            this.FunctionList_toolStripComboBox.Size = new System.Drawing.Size(155, 32);
            this.FunctionList_toolStripComboBox.Sorted = true;
            this.FunctionList_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionList_toolStripComboBox_SelectedIndexChanged);
            // 
            // work_panel
            // 
            this.work_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.work_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.work_panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.work_panel.Location = new System.Drawing.Point(0, 71);
            this.work_panel.Name = "work_panel";
            this.work_panel.Size = new System.Drawing.Size(1342, 579);
            this.work_panel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.InfoNote_toolStripMenuItem,
            this.Settings_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1342, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportIn_ToolStripMenuItem,
            this.SaveFunction_toolStripMenuItem,
            this.SaveSession_toolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 26);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // ExportIn_ToolStripMenuItem
            // 
            this.ExportIn_ToolStripMenuItem.Name = "ExportIn_ToolStripMenuItem";
            this.ExportIn_ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.ExportIn_ToolStripMenuItem.Text = "Экспорт в";
            this.ExportIn_ToolStripMenuItem.Click += new System.EventHandler(this.ExportIn_ToolStripMenuItem_Click);
            // 
            // SaveFunction_toolStripMenuItem
            // 
            this.SaveFunction_toolStripMenuItem.Name = "SaveFunction_toolStripMenuItem";
            this.SaveFunction_toolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.SaveFunction_toolStripMenuItem.Text = "Сохранить функцию";
            this.SaveFunction_toolStripMenuItem.Click += new System.EventHandler(this.SaveFunction_toolStripMenuItem_Click);
            // 
            // InfoNote_toolStripMenuItem
            // 
            this.InfoNote_toolStripMenuItem.Name = "InfoNote_toolStripMenuItem";
            this.InfoNote_toolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.InfoNote_toolStripMenuItem.Text = "Справка";
            this.InfoNote_toolStripMenuItem.Click += new System.EventHandler(this.InfoNote_toolStripMenuItem_Click);
            // 
            // Settings_ToolStripMenuItem
            // 
            this.Settings_ToolStripMenuItem.Name = "Settings_ToolStripMenuItem";
            this.Settings_ToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.Settings_ToolStripMenuItem.Text = "Настройки";
            this.Settings_ToolStripMenuItem.Click += new System.EventHandler(this.Settings_ToolStripMenuItem_Click);
            // 
            // SaveSession_toolStripMenuItem
            // 
            this.SaveSession_toolStripMenuItem.Name = "SaveSession_toolStripMenuItem";
            this.SaveSession_toolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.SaveSession_toolStripMenuItem.Text = "Сохранить сессию";
            this.SaveSession_toolStripMenuItem.Click += new System.EventHandler(this.SaveSession_toolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1342, 650);
            this.Controls.Add(this.work_panel);
            this.Controls.Add(this.main_toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1360, 550);
            this.Name = "MainForm";
            this.Text = "Графики";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.main_toolStrip.ResumeLayout(false);
            this.main_toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip main_toolStrip;
        private System.Windows.Forms.ToolStripComboBox FunctionList_toolStripComboBox;
        private System.Windows.Forms.Panel work_panel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExportIn_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoNote_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFunction_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSession_toolStripMenuItem;
    }
}