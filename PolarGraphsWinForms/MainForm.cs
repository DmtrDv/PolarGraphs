using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarGraphsWinForms
{
    public partial class MainForm: Form
    {
        private CreatingNewFunctionForm currentFunctionForm;
        public MainForm()
        {
            InitializeComponent();
            ShowFormInWorkArea(new CreatingNewFunctionForm());
        }
        private void ShowFormInWorkArea(CreatingNewFunctionForm form)
        {
            currentFunctionForm = form;
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

        private void exportIn_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли активная форма с графиком
            if (currentFunctionForm == null || currentFunctionForm.cartesianGraph_chart.Series[0].Points == null)
            {
                MessageBox.Show("Нет активного графика для экспорта.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Создаем диалог выбора формата и сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Экспорт графика";
                saveFileDialog.FileName = "graph_export";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Определяем формат изображения по расширению файла
                        ImageFormat format;
                        string extension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();

                        switch (extension)
                        {
                            case ".jpg":
                            case ".jpeg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".png":
                            default:
                                format = ImageFormat.Png;
                                break;
                        }

                        // Экспортируем график
                        ExportChartToImage(currentFunctionForm.cartesianGraph_chart, saveFileDialog.FileName, format);

                        MessageBox.Show($"График успешно экспортирован в {saveFileDialog.FileName}",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте графика: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ExportChartToImage(System.Windows.Forms.DataVisualization.Charting.Chart chart, string fileName, ImageFormat format)
        {
            // Сохраняем оригинальные настройки
            var originalBackColor = chart.BackColor;

            try
            {
                // Устанавливаем белый фон для экспорта
                chart.BackColor = Color.White;

                // Экспортируем график в указанный файл
                chart.SaveImage(fileName, format);
            }
            finally
            {
                // Восстанавливаем оригинальный фон
                chart.BackColor = originalBackColor;
            }
        }
    }
}