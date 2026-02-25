using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PolarGraphsWinForms
{
    public partial class Form1 : Form
    {
        double a, b, h, x, y;

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkBox_cos.Checked && !this.checkBox_sin.Checked)
            {
                MessageBox.Show("Выберите хотя бы один график!", "Внимание");
                return;
            }

            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_h.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание");
                DefaultParams();
            }

            if (checkBox_cos.Checked)
            {
                chart.Series[0].Points.Clear();
            }

            if (checkBox_sin.Checked)
            {
                chart.Series[1].Points.Clear();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.checkBox_cos.Checked && !this.checkBox_sin.Checked)
            {
                MessageBox.Show("Выберите хотя бы один график!", "Внимание");
                return;
            }


            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_h.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание");
                DefaultParams();
            }

            else 
            {
                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                h = Convert.ToDouble(textBox_h.Text);
            }
            this.chart.Series[0].Points.Clear();
            this.chart.Series[1].Points.Clear();
            
            x = a;

            while (x <= b)
            {
                if (checkBox_cos.Checked)
                { 
                y = Math.Cos(x);
                this.chart.Series[0].Points.AddXY(x, y);
                }

                if (checkBox_sin.Checked)
                {
                    y = Math.Sin(x);
                    this.chart.Series[1].Points.AddXY(x, y);
                }

                x += h;

            }

        }
        void DefaultParams()
        {
            a = -10;
            b = 10;
            h = 0.1;

            textBox_a.Text = a.ToString();
            textBox_b.Text = b.ToString();
            textBox_h.Text = h.ToString();
        }
    }
}
