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
    public partial class LineSettingsForm: Form
    {
        public Color color { get; private set; }
        public int thicknessLine { get; private set; }
        public Color currentColor_;
        private int currentThickness_;
        public LineSettingsForm(Color currentColor, int currentThickness)
        {
            InitializeComponent();
            currentColor_ = currentColor;
            currentThickness_ = currentThickness;
            // Одна строка - перемещение за любую область формы
            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }
        private void LineSettingsForm_Load(object sender, EventArgs e)
        {
            colorDialog_pictureBox.BackColor = currentColor_;
            thickness_numericUpDown.Value = currentThickness_;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            color = currentColor_;
            thicknessLine = (int)thickness_numericUpDown.Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void colorDialog_pictureBox_Click(object sender, EventArgs e)
        {
            if (colorLine_colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor_ = colorLine_colorDialog.Color;
                colorDialog_pictureBox.BackColor = currentColor_;
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
