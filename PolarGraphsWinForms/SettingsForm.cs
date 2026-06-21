using PolarGraphsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
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
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
    }
}
