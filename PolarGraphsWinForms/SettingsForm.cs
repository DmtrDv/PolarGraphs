using PolarGraphsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarGraphsWinForms
{
    public partial class SettingsForm: Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            ThemeMode.Apply(this);
            DarkMode_checkBox.Checked = ThemeMode.IsDarkMode;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DarkMode_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode_checkBox.Checked)
            {
                ThemeMode.SetDark();
            }
            else
            {
                ThemeMode.SetLight();
            }
        }
    }
}
