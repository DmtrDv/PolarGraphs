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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowFormInWorkArea(new CreatingNewFunctionForm());
        }
        private void ShowFormInWorkArea(CreatingNewFunctionForm form)
        {
            // Закрыть текущую форму
            /*if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose(); //освобождает ресурсы
            }*/

            // Настраиваем новую форму
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;

            // Добавляем в рабочую область
            this.work_panel.Controls.Clear();
            this.work_panel.Controls.Add(form);

            /*currentForm = form;

            // Обновляем заголовок главного окна
            this.Text = "Спортивная школа - " + form.Text;

            FindOf_label.Enabled = true;
            FindOf_textBox.Enabled = true;
            FindOf_textBox.Text = "";*/

        }
    }
}
