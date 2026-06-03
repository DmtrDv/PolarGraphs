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
        private CreatingNewFunctionForm currentFunctionForm;
        /*private List<PolarFunction> list = new List<PolarFunction>() { 
            (new PolarFunction { Id = 0, Name = "Астроида", Function = "1/( Pow( Pow(abs(cos(fi)), 2/3) + Pow(abs(sin(fi)), 2/3) , 3/2) )", Step = 0.1, StartCorner = 0, EndCorner = 360 }),
            (new PolarFunction { Id = 1, Name = "Улитка Паскаля", Function = "cos(fi)+0.25", Step = 1, StartCorner = 0, EndCorner = 360 }),
            (new PolarFunction { Id = 2, Name = "Кардиоида", Function = "Pow(2*(1+cos(fi)), 0.25)", Step = 1, StartCorner = 0, EndCorner = 360 }),
            (new PolarFunction { Id = 3, Name = "Листочек", Function = "(1 + sin(9*fi))*(1 + sin(fi))*(1 + 0.03*sin(9*5*fi))*(1 + 0.04*sin(9*33*fi))", Step = 0.1, StartCorner = 0, EndCorner = 360}),
            //(new ListPolarFunction { Id = 4, Name = "Парабола", Function = "sin(fi)/Pow(cos(fi), 2)" }),
            (new PolarFunction {Id = 4, Name = "Сердце", Function = "2-2*sin(fi)+sin(fi)*sqrt(abs(cos(fi)))/(sin(fi)+1.4)", Step = 0.1, StartCorner = 0, EndCorner = 360}),
            (new PolarFunction {Id = 5, Name = "Бабочка", Function = "Abs((1.5*Sin(fi)) + (0.8*Sin(2*fi)) + (0.6*Sin(3*fi)))*(1 + (0.3*Cos(5*fi)))", Step = 3, StartCorner = 0, EndCorner = 360})};*/
        private List<PolarFunction> listFunctions_ = ReadingAndWriting.ReadPolarFunction();
        PolarFunction func;
        public MainForm()
        {
            InitializeComponent();
            ThemeMode.RegisterChartHandler();
            ShowFormInWorkArea(new CreatingNewFunctionForm());

            for (int i = 0; i < listFunctions_.Count; i++)
            {
                FunctionList_toolStripComboBox.Items.Add(listFunctions_[i].Name);
            }
            ThemeMode.Apply(this);
        }
        private void ShowFormInWorkArea(CreatingNewFunctionForm form)
        {
            // Закрыть текущую форму
            if (currentFunctionForm != null)
            {
                currentFunctionForm.Close();
                currentFunctionForm.Dispose(); //освобождает ресурсы
            }
            currentFunctionForm = form;

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

        private void ExportIn_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли активная форма с графиком
            if (currentFunctionForm == null || currentFunctionForm.cartesianGraph_chart.Series[0].Points.Count == 0)
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
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void InfoNote_toolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}