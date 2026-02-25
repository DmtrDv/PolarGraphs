using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolarGraphsWinForms
{
    public partial class astroida: Form
    {

        double a, phiMin, phiMax;
        int CountPoints;
        double phiStep;

        public astroida()
        {
            InitializeComponent();
        }

        private void CreateGraph_button_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(a_textBox.Text);

            CountPoints = Convert.ToInt32(CountPoints_textBox.Text);
            phiMin = Convert.ToDouble(Start_fi_textBox.Text) * Math.PI / 180;
            phiMax = Convert.ToDouble(End_fi_textBox.Text) * Math.PI / 180;
            phiStep = (phiMax - phiMin) / CountPoints;

            this.chart1.Series[0].Points.Clear();
            this.chart.Series[0].Points.Clear();
            for (int i = 0; i <= CountPoints; i++)
            {
                double phi = phiMin + i * phiStep;

                // r = a * sqrt(cos⁶φ + sin⁶φ)
                double phiCos = Convert.ToDouble(CosValue_textBox.Text) * Math.Cos(phi);
                double phiSin = Convert.ToDouble(SinValue_textBox.Text) * Math.Sin(phi);
                double cos6 = Math.Pow(phiCos, 6);
                double sin6 = Math.Pow(phiSin, 6);
                double r = a * Math.Sqrt(cos6 + sin6);

                double x = r * Math.Pow(phiCos, 3);
                double y = r * Math.Pow(phiSin, 3);

                chart1.Series[0].Points.AddXY(x, y);
                chart.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
