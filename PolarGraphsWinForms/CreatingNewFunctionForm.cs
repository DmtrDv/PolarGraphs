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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolarGraphsWinForms
{
    public partial class CreatingNewFunctionForm: Form
    {
        public CreatingNewFunctionForm()
        {
            InitializeComponent();
        }
        
        private void build_button_Click(object sender, EventArgs e)
        {
            polarGraph_chart.Series[0].Points.Clear();
            сartesianGraph_chart.Series[0].Points.Clear();

            string function = function_textBox.Text;
            float startConcer = (float)startСorner_numericUpDown.Value;
            float endConcer = (float)endСorner_numericUpDown.Value;
            float step = (float)step_numericUpDown.Value;

            ChartArea polarArea = polarGraph_chart.ChartAreas[0];
            polarArea.AxisX.Minimum = -1.5;
            polarArea.AxisX.Maximum = 1.5;
            polarArea.AxisY.Minimum = -1.5;
            polarArea.AxisY.Maximum = 1.5;
            polarArea.AxisX.Crossing = 0;
            polarArea.AxisY.Crossing = 0;
            polarArea.AxisX.Interval = 0.5;
            polarArea.AxisY.Interval = 0.5;

            // Настройка декартоволго графика
            ChartArea cartesianArea = сartesianGraph_chart.ChartAreas[0];
            cartesianArea.AxisX.Minimum = -1.5;
            cartesianArea.AxisX.Maximum = 1.5;
            cartesianArea.AxisY.Minimum = -1.5;
            cartesianArea.AxisY.Maximum = 1.5;
            cartesianArea.AxisX.Crossing = 0;
            cartesianArea.AxisY.Crossing = 0;
            for (double concer = startConcer; concer <= endConcer; concer += step)
            {
                double concerRad = concer * Math.PI / 180;


                string expression = function.ToLower()
                     .Replace(" ", "")
                     .Replace("sin", "Sin")
                     .Replace("cos", "Cos")
                     .Replace("tan", "Tan")
                     .Replace("sqrt", "Sqrt")
                     .Replace("log", "Log")
                     .Replace("asin", "Asin")
                     .Replace("acos", "Acos")
                     .Replace("atan", "Atan")
                     ;

                // .Replace("fi", concerRad.ToString(System.Globalization.CultureInfo.InvariantCulture));
                NCalc.Expression expr = new NCalc.Expression(expression);
                expr.Parameters["fi"] = concerRad;

                double r = Convert.ToDouble(expr.Evaluate());

                polarGraph_chart.Series[0].Points.AddXY(concerRad, r);


                double x = r * Math.Cos(concerRad);
                double y = r * Math.Sin(concerRad);

                сartesianGraph_chart.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
