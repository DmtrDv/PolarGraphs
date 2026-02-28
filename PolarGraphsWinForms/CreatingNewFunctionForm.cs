using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NCalc;
using PolarGraphsLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolarGraphsWinForms
{
    public partial class CreatingNewFunctionForm: Form
    {
        //астроида: 1/( Pow( Pow(abs(cos(fi)), 2/3) + Pow(abs(sin(fi)), 2/3) , 3/2) ) // чтоб изменить высоту и ширину нужно sin или cos умножить
        //Улитка Паскаля: cos(fi)+0.25
        //Кардиоида: Pow(2*(1+cos(fi)), 0.25)
        //конопля  (1 + sin(9*fi))*(1 + sin(fi))*(1 + 0.03*sin(9*5*fi))*(1 + 0.04*sin(9*33*fi))
        //парабола sin(fi)/Pow(cos(fi), 2)
        //Abs((1.5*Sin(fi)) + (0.8*Sin(2*fi)) + (0.6*Sin(3*fi)))*(1 + (0.3*Cos(5*fi)))
        public CreatingNewFunctionForm()
        {
            InitializeComponent();
        }
        ReadUserFunction readFunction = new ReadUserFunction();
        private void build_button_Click(object sender, EventArgs e)
        {
           // polarGraph_chart.Series[0].Points.Clear();
            сartesianGraph_chart.Series[0].Points.Clear();

            string function = function_textBox.Text;
            double startConcer = (double)startСorner_numericUpDown.Value;
            double endConcer = (double)endСorner_numericUpDown.Value;
            double step = (double)step_numericUpDown.Value;

            /*ChartArea polarArea = polarGraph_chart.ChartAreas[0];
            polarArea.AxisX.Minimum = -1.5;
            polarArea.AxisX.Maximum = 1.5;
            polarArea.AxisY.Minimum = -1.5;
            polarArea.AxisY.Maximum = 1.5;
            polarArea.AxisX.Crossing = 0;
            polarArea.AxisY.Crossing = 0;
            polarArea.AxisX.Interval = 0.5;
            polarArea.AxisY.Interval = 0.5;*/

            // Настройка декартоволго графика
            ChartArea cartesianArea = сartesianGraph_chart.ChartAreas[0];
            cartesianArea.AxisX.Minimum = -5;
            cartesianArea.AxisX.Maximum = 5;
            cartesianArea.AxisY.Minimum = -5;
            cartesianArea.AxisY.Maximum = 5;
            cartesianArea.AxisX.Crossing = 0;
            cartesianArea.AxisY.Crossing = 0;

            var (listPolarPoints, listCartesianPoints) = readFunction.ConvertUserFunction(startConcer, endConcer, step, function);

           /* foreach (Points point in listPolarPoints)
            {
                polarGraph_chart.Series[0].Points.AddXY(point.coordinateX, point.coordinateY);
            }*/
            foreach (Points point in listCartesianPoints)
            {
                сartesianGraph_chart.Series[0].Points.AddXY(point.coordinateX, point.coordinateY);
            }
        }

        private void addons_button_Click(object sender, EventArgs e)
        {
            LineSettingsForm lineSettingsForm = new LineSettingsForm();
            if (lineSettingsForm.ShowDialog() == DialogResult.OK)
            {
                int red = lineSettingsForm.redColor;
                int green = lineSettingsForm.greenColor;
                int blue = lineSettingsForm.blueColor;
                int thickness = lineSettingsForm.thicknessLine;

                Color newColor = Color.FromArgb(red, green, blue);

                сartesianGraph_chart.Series[0].Color = newColor;
                сartesianGraph_chart.Series[0].BorderWidth = thickness;
            }
        }

        private void Info_label_Click(object sender, EventArgs e)
        {
            infoRightInput_toolTip.Show(info, Info_label, 15000);
        }



        string info = "Информация:\r\n\tВсе числа пишите через точку: 0.5, 1.5, 3.14\r\n\tФункции вводятся в любом регистре.\r\n\r\nДоступные функции:\r\n\r\nФункция\t  Описание\t        Пример\r\nsin()\t  Синус\t\t\tsin(fi), sin(2*fi)\r\ncos()\t  Косинус\t\tcos(fi), cos(3*fi)\r\nasin()\t  Арксинус\t\tasin(0.5)\r\nacos()\t  Арккосинус\t\tacos(0.5)\r\nsqrt()\t  Квадратный корень\tsqrt(4)\r\npow()\t  Возведение в степень\tpow(2,3) = 2³\r\nabs()\t  Модуль\t\tabs(-5) = 5\r\n\r\nКонстанты:\r\nPi число π\r\nE  число е\r\n\r\nАрифметические операции:\r\n    + сложение\r\n    - вычитание\r\n    * умножение\r\n    / деление\r\n    pow() степень\r\n\r\nИспользуйте fi для угла в радианах\r\nПример: sin(fi), 2*cos(fi) + sin(2*fi)\r\n\r\nНЕЛЬЗЯ:\r\nПропускать знак умножения:\r\n    2sin(fi) → ошибка\r\n    2*sin(fi) → правильно\r\n\r\nИспользовать неизвестные функции:\r\n    sec(fi) → ошибка (нет такой функции)\r\n\r\nНеправильные скобки:\r\n    sin(fi → ошибка\r\n    sin(fi) → правильно";
    }
}
