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
        public int redColor { get; private set; }
        public int greenColor { get; private set; }
        public int blueColor { get; private set; }
        public int thicknessLine { get; private set; }
        private Color _currentColor;
        private int _currentThickness;
        public LineSettingsForm(Color currentColor, int currentThickness)
        {
            InitializeComponent();
            _currentColor = currentColor;
            _currentThickness = currentThickness;
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
            red_numericUpDown.Value = _currentColor.R;
            green_numericUpDown.Value = _currentColor.G;
            blue_numericUpDown.Value = _currentColor.B;
            thickness_numericUpDown.Value = _currentThickness;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            redColor = (int)red_numericUpDown.Value;
            greenColor = (int)green_numericUpDown.Value;
            blueColor = (int)blue_numericUpDown.Value;
            thicknessLine = (int)thickness_numericUpDown.Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
