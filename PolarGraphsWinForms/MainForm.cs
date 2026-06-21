using PolarGraphsLib;
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
        private CreatingNewFunctionForm currentFunctionForm_;
        private List<PolarFunction> listFunctions_ = ReadingAndWriting.ReadPolarFunction();
        PolarFunction func;
        public MainForm()
        {
            InitializeComponent();

            PolarFunction lastPolarFunction;
            bool pointsOnChart;
            (lastPolarFunction, pointsOnChart) = SavingAndPullingUpSession.PullingUpSession();
            FunctionList_toolStripComboBox.Text = lastPolarFunction.Name;
            ShowFormInWorkArea(new CreatingNewFunctionForm(lastPolarFunction));
            if (pointsOnChart)
            {
                currentFunctionForm_.BuildGraph();
            }
            for (int i = 0; i < listFunctions_.Count; i++)
            {
                FunctionList_toolStripComboBox.Items.Add(listFunctions_[i].Name);
            }

            ThemeMode.RegisterChartHandler();
            ThemeMode.Apply(this);
        }
        private void ShowFormInWorkArea(CreatingNewFunctionForm form)
        {
            // Закрыть текущую форму
            if (currentFunctionForm_ != null)
            {
                currentFunctionForm_.Close();
                currentFunctionForm_.Dispose(); //освобождает ресурсы
            }
            currentFunctionForm_ = form;

            // Настраиваем новую форму
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;

            // Добавляем в рабочую область
            this.work_panel.Controls.Clear();
            this.work_panel.Controls.Add(form);
        }

        private void ExportIn_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли активная форма с графиком
            if (currentFunctionForm_ == null || currentFunctionForm_.cartesianGraph_chart.Series[0].Points.Count == 0)
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
                        ExportChartToImage(currentFunctionForm_.cartesianGraph_chart, saveFileDialog.FileName, format);

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
                chart.BackColor = ThemeMode.IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;

                // Экспортируем график в указанный файл
                chart.SaveImage(fileName, format);
            }
            finally
            {
                // Восстанавливаем оригинальный фон
                chart.BackColor = originalBackColor;
            }
        }
        private void FunctionList_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string function = FunctionList_toolStripComboBox.Text;
            
            foreach (PolarFunction polarFunction in listFunctions_)
            {
                if (function == polarFunction.Name)
                {
                    func = polarFunction;
                    ShowFormInWorkArea(new CreatingNewFunctionForm(func));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить текущее состояние?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                SaveCurrentSession();
            }
            else { }
        }

        private void InfoNote_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is InformationNote)
                {
                    form.Activate();
                    return;
                }
            }
            InformationNote informationNote = new InformationNote();
            informationNote.Show();
        }

        private void Settings_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void SaveFunction_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatingNewFunctionForm newFunction = Application.OpenForms["CreatingNewFunctionForm"] as CreatingNewFunctionForm;
            PolarFunction function = newFunction.GetCurrentPolarFunction(listFunctions_.Count, FunctionList_toolStripComboBox.Text);
            if (string.IsNullOrEmpty(function.Function))
            {
                MessageBox.Show("Функция не может быть пустой", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveUserFunctionForm saveUserFunction = new SaveUserFunctionForm(function, listFunctions_);
            if (saveUserFunction.ShowDialog() == DialogResult.Yes)
            {
                listFunctions_ = ReadingAndWriting.ReadPolarFunction();
                FunctionList_toolStripComboBox.Items.Clear();
                for (int i = 0; i < listFunctions_.Count; i++)
                {
                    FunctionList_toolStripComboBox.Items.Add(listFunctions_[i].Name);
                }
            }
        }

        private void SaveSession_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentSession();
        }
        private void SaveCurrentSession()
        {
            CreatingNewFunctionForm functionForm = Application.OpenForms["CreatingNewFunctionForm"] as CreatingNewFunctionForm;
            bool isPointsOnChart = functionForm.IsPointsOnChart();
            PolarFunction function = functionForm.GetCurrentPolarFunction(-1, FunctionList_toolStripComboBox.Text);

            SavingAndPullingUpSession.SaveSession(function, isPointsOnChart);
        }
    }
}