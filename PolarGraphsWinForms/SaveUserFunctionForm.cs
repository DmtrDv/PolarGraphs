using NCalc.Domain;
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
    public partial class SaveUserFunctionForm: Form
    {
        private PolarFunction polarFunction_;
        private List<PolarFunction> listPolarFunction_;
        public SaveUserFunctionForm(PolarFunction function, List<PolarFunction> listPolarFunction)
        {
            InitializeComponent();

            polarFunction_ = function;
            listPolarFunction_ = listPolarFunction;
    
            name_textBox.Text = polarFunction_.Name;
            function_richTextBox.Text = polarFunction_.Function;

            this.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
            ThemeMode.Apply(this);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            polarFunction_.Name = name_textBox.Text;
            if (string.IsNullOrEmpty(polarFunction_.Name))
            {
                MessageBox.Show("Введите название для функции", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (PolarFunction polarFunction in listPolarFunction_)
            {
                if (polarFunction.Name.ToLower().Contains(polarFunction_.Name.ToLower()))
                {
                    MessageBox.Show("Такая функция уже существует", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            listPolarFunction_.Add(polarFunction_);
            ReadingAndWriting.WritePolarFunction(listPolarFunction_);

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
    }
}
