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
            cartesianArea.AxisX.Minimum = -1.5 * step;
            cartesianArea.AxisX.Maximum = 1.5 * step;
            cartesianArea.AxisY.Minimum = -1.5 * step;
            cartesianArea.AxisY.Maximum = 1.5 * step;
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
    }
}
