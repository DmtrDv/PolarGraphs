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
            float startConcer = (float)startСorner_numericUpDown.Value;
            float endConcer = (float)endСorner_numericUpDown.Value;
            float step = (float)step_numericUpDown.Value;

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
    }
}
