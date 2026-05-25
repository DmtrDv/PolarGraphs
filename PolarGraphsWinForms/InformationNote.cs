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
    public partial class InformationNote: Form
    {
        string info = "Информация:\r\n\tВсе числа пишите через точку: 0.5, 1.5, 3.14\r\n\tФункции вводятся в любом регистре.\r\n\r\nДоступные функции:\r\n\r\nФункция\t  Описание\t        Пример\r\nsin()\t  Синус\t\t\tsin(fi), sin(2*fi)\r\ncos()\t  Косинус\t\tcos(fi), cos(3*fi)\r\nasin()\t  Арксинус\t\tasin(0.5)\r\nacos()\t  Арккосинус\t\tacos(0.5)\r\nsqrt()\t  Квадратный корень\tsqrt(4)\r\npow()\t  Возведение в степень\tpow(2,3) = 2³\r\nabs()\t  Модуль\t\t\tabs(-5) = 5\r\n\r\nКонстанты:\r\nPi число π\r\nE  число е\r\n\r\nАрифметические операции:\r\n    + сложение\r\n    - вычитание\r\n    * умножение\r\n    / деление\r\n    pow() степень\r\n\r\nИспользуйте fi для угла в радианах\r\nПример: sin(fi), 2*cos(fi) + sin(2*fi)\r\n\r\nНЕЛЬЗЯ:\r\nПропускать знак умножения:\r\n    2sin(fi) → ошибка\r\n    2*sin(fi) → правильно\r\n\r\nИспользовать неизвестные функции:\r\n    sec(fi) → ошибка (нет такой функции)\r\n\r\nНеправильные скобки:\r\n    sin(fi → ошибка\r\n    sin(fi) → правильно";

        public InformationNote()
        {
            InitializeComponent();
            info_richTextBox.Text = info;

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

        private void Close_button_Click(object sender, EventArgs e)
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
