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
        private List<Points> currentListPoints_ = new List<Points>();
        private int indexCurrentListPoints_;
        private Timer animationTimer_ = new Timer();
        private int currentQuantityDrawnPoints_;

        public CreatingNewFunctionForm()
        {
            InitializeComponent();
            infoRightInput_toolTip.Draw += infoRightInput_toolTip_Draw;
            infoRightInput_toolTip.Popup += infoRightInput_toolTip_Popup;
            ThemeMode.Apply(this);
        }

        public CreatingNewFunctionForm(PolarFunction func)
        {
            InitializeComponent();
            function_richTextBox.Text = func.Function;
            startСorner_numericUpDown.Value = (decimal)func.StartCorner;
            endСorner_numericUpDown.Value = (decimal)func.EndCorner;
            step_numericUpDown.Value = (decimal)func.Step;


            infoRightInput_toolTip.Draw += infoRightInput_toolTip_Draw;
            infoRightInput_toolTip.Popup += infoRightInput_toolTip_Popup;
            ThemeMode.Apply(this);
        }
        ReadUserFunction readFunction = new ReadUserFunction();
        private void build_button_Click(object sender, EventArgs e)
        {
            try
            {
                animationTimer_.Stop();
                // polarGraph_chart.Series[0].Points.Clear();
                cartesianGraph_chart.Series[0].Points.Clear();

                string function = function_richTextBox.Text;
                double startConcer = (double)startСorner_numericUpDown.Value;
                double endConcer = (double)endСorner_numericUpDown.Value;
                double step = (double)step_numericUpDown.Value;

                if (string.IsNullOrWhiteSpace(function))
                {
                    MessageBox.Show("Введите функцию.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (startСorner_numericUpDown.Value >= endСorner_numericUpDown.Value)
                {
                    MessageBox.Show("Начальный угол должен быть меньше конечного угла.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var (listPolarPoints, listCartesianPoints) = readFunction.ConvertUserFunction(startConcer, endConcer, step, function);

                // Настройка декартоволго графика
                (double axisXMax, double axisYMax) = MaxXY(listCartesianPoints);
                (double axisXMin, double axisYMin) = MinXY(listCartesianPoints);

                ChartArea cartesianArea = cartesianGraph_chart.ChartAreas[0];
                cartesianArea.AxisX.Crossing = 0;
                cartesianArea.AxisY.Crossing = 0;
                cartesianArea.AxisX.Maximum = axisXMax;
                cartesianArea.AxisY.Maximum = axisYMax;
                cartesianArea.AxisX.Minimum = axisXMin;
                cartesianArea.AxisY.Minimum = axisYMin;
                /*ChartArea polarArea = polarGraph_chart.ChartAreas[0];
                polarArea.AxisX.Minimum = -1.5;
                polarArea.AxisX.Maximum = 1.5;
                polarArea.AxisY.Minimum = -1.5;
                polarArea.AxisY.Maximum = 1.5;
                polarArea.AxisX.Crossing = 0;
                polarArea.AxisY.Crossing = 0;
                polarArea.AxisX.Interval = 0.5;
                polarArea.AxisY.Interval = 0.5;*/
                
                /* foreach (Points point in listPolarPoints)
                 {
                     polarGraph_chart.Series[0].Points.AddXY(point.coordinateX, point.coordinateY);
                 }*/
                if (animation_checkBox.Checked)
                {
                    animationTimer_.Interval = (int)(111 - (int)speedAnimation_numericUpDown.Value * 11);
                    animationTimer_.Tick += AnimationBuild;
                    indexCurrentListPoints_ = 0;
                    currentQuantityDrawnPoints_ = 0;
                    currentListPoints_ = listCartesianPoints;
                    animationTimer_.Start();
                }
                else
                {
                    foreach (Points point in listCartesianPoints)
                    {
                        cartesianGraph_chart.Series[0].Points.AddXY(point.coordinateX, point.coordinateY);
                    }
                }
                /*if (cartesianGraph_chart.Series[0].Points.Count == 0)
                {
                    MessageBox.Show($"Ошибка: функция не содержит точек",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                //MessageBox.Show($"{listCartesianPoints.Count}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка функции или её значений:\n{ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void AnimationBuild(object sender, EventArgs eventArgs)
        {
            if (currentListPoints_ == null || indexCurrentListPoints_ == currentListPoints_.Count)
            {
                animationTimer_.Stop();
                return;
            }
            if ((111 - (int)speedAnimation_numericUpDown.Value * 11) != animationTimer_.Interval)
            {
                animationTimer_.Interval = (int)(111 - (int)speedAnimation_numericUpDown.Value * 11);
            }

            int countPointInTick = (int)pointInTick_numericUpDown.Value;

            int remainingPoints = currentListPoints_.Count - currentQuantityDrawnPoints_;
            if (remainingPoints < countPointInTick)
            {
                countPointInTick = remainingPoints;
            }

            for (int i = 0; i < countPointInTick; i++)
            {
                Points point = currentListPoints_[indexCurrentListPoints_];
                cartesianGraph_chart.Series[0].Points.AddXY(point.coordinateX, point.coordinateY);
                indexCurrentListPoints_++;
            }
            currentQuantityDrawnPoints_ += countPointInTick;
        }
        private void addons_button_Click(object sender, EventArgs e)
        {
            LineSettingsForm lineSettingsForm = new LineSettingsForm(cartesianGraph_chart.Series[0].Color, cartesianGraph_chart.Series[0].BorderWidth);
            if (lineSettingsForm.ShowDialog() == DialogResult.OK)
            {
                int thickness = lineSettingsForm.thicknessLine;
                Color newColor = lineSettingsForm.color;

                cartesianGraph_chart.Series[0].Color = newColor;
                cartesianGraph_chart.Series[0].BorderWidth = thickness;
            }
        }

        private void Info_label_Click(object sender, EventArgs e)
        {
            infoRightInput_toolTip.Show(info, Info_label, 15000);
        }



        string info = "Информация:\r\n\tВсе числа пишите через точку: 0.5, 1.5, 3.14\r\n\tФункции вводятся в любом регистре.\r\n\r\nДоступные функции:\r\n\r\nФункция\t  Описание\t        Пример\r\nsin()\t  Синус\t\t\tsin(fi), sin(2*fi)\r\ncos()\t  Косинус\t\tcos(fi), cos(3*fi)\r\nasin()\t  Арксинус\t\tasin(0.5)\r\nacos()\t  Арккосинус\t\tacos(0.5)\r\nsqrt()\t  Квадратный корень\tsqrt(4)\r\npow()\t  Возведение в степень\tpow(2,3) = 2³\r\nabs()\t  Модуль\t\t\tabs(-5) = 5\r\n\r\nКонстанты:\r\nPi число π\r\nE  число е\r\n\r\nАрифметические операции:\r\n    + сложение\r\n    - вычитание\r\n    * умножение\r\n    / деление\r\n    pow() степень\r\n\r\nИспользуйте fi для угла в радианах\r\nПример: sin(fi), 2*cos(fi) + sin(2*fi)\r\n\r\nНЕЛЬЗЯ:\r\nПропускать знак умножения:\r\n    2sin(fi) → ошибка\r\n    2*sin(fi) → правильно\r\n\r\nИспользовать неизвестные функции:\r\n    sec(fi) → ошибка (нет такой функции)\r\n\r\nНеправильные скобки:\r\n    sin(fi → ошибка\r\n    sin(fi) → правильно";

        private void infoRightInput_toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            using (Font newFont = new Font("Times New Roman", 13))
            {
                e.Graphics.DrawString(e.ToolTipText, newFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void infoRightInput_toolTip_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(420, 805);
        }

        private static (double, double) MaxXY(List<Points>list)
        {
            double maxX = list[0].coordinateX;
            double maxY = list[0].coordinateY;

            for (int i = 0; i < list.Count; i++)
            {
                if (maxX < list[i].coordinateX)
                {
                    maxX = list[i].coordinateX;
                }

                if (maxY < list[i].coordinateY)
                {
                    maxY = list[i].coordinateY;
                }
            }
            return (maxX+0.25, maxY+0.25);
        }
        private static (double, double) MinXY(List<Points> list)
        {
            double minX = list[0].coordinateX;
            double minY = list[0].coordinateY;

            for (int i = 0; i < list.Count; i++)
            {
                if (minX > list[i].coordinateX)
                {
                    minX = list[i].coordinateX;
                }

                if (minY > list[i].coordinateY)
                {
                    minY = list[i].coordinateY;
                }
            }
            return (minX-0.25, minY-0.25);
        }

        private void speed_trackBar_Scroll(object sender, EventArgs e)
        {
            speedAnimation_numericUpDown.Value = speed_trackBar.Value;
        }

        private void speedAnimation_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            speed_trackBar.Value = (int)speedAnimation_numericUpDown.Value;
        }
        public PolarFunction GetCurrentPolarFunction(int id, string name)
        {
            PolarFunction function = new PolarFunction() { Id = id, Name = name, Function = function_richTextBox.Text, Step = (double)step_numericUpDown.Value, 
                                                           StartCorner = (double)startСorner_numericUpDown.Value, EndCorner = (double)endСorner_numericUpDown.Value};
            return function;
        }
    }
}
