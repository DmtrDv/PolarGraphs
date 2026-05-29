using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PolarGraphsLib
{
    public class ThemeMode
    {


        // Стандартный светлый фон для контролов без сохранённого исходного цвета
        public static Color DefaultBackColor { get; } = SystemColors.Control;

        // Стандартный светлый текст для контролов без сохранённого исходного цвета
        public static Color DefaultForeColor { get; } = SystemColors.ControlText;

        private static double _darkFactor = 0.75;
        private static double _lightFactor = 0.9;

        // Включена ли тёмная тема
        public static bool IsDarkMode { get; private set; }

        // Пользовательские обработчики для конкретных типов контролов
        public static Dictionary<Type, Action<Control, bool>> CustomHandlers { get; } = new Dictionary<Type, Action<Control, bool>>();

        // Сохранённые исходные цвета (светлая тема) для каждого контрола
        private static readonly Dictionary<Control, (Color Back, Color Fore)> OriginalColors = new Dictionary<Control, (Color Back, Color Fore)>();

        // Зарегистрировать кастомный обработчик темы для типа контрола
        public static void RegisterCustomHandler(Type controlType, Action<Control, bool> handler)
        {
            if (controlType == null || handler == null)
                return;
            CustomHandlers[controlType] = handler;
        }

        // Зарегистрировать готовый обработчик для Chart (Windows Forms DataVisualization)
        public static void RegisterChartHandler()
        {
            RegisterCustomHandler(typeof(Chart), (ctrl, isDark) =>
            {
                if (ctrl is Chart chart)
                    ApplyChartTheme(chart, isDark);
            });
        }

        // Переключиться на светлую тему и восстановить исходные цвета
        public static void SetLight()
        {
            IsDarkMode = false;
            RestoreAllOpenForms();
            OriginalColors.Clear();
        }

        public static void SetDark(double darkFactor = 0.75, double lightFactor = 0.9)
        {
            _darkFactor = Math.Max(0, Math.Min(1, darkFactor));
            _lightFactor = Math.Max(0, Math.Min(1, lightFactor));

            if (OriginalColors.Count == 0)
                SaveAllOpenForms();

            IsDarkMode = true;
            UpdateAllOpenForms();
        }

        // Применить текущую тему к форме и сохранить исходные цвета
        public static void Apply(Form form)
        {
            if (form == null) return;

            // При тёмной теме гарантируем, что исходные цвета формы сохранены
            if (IsDarkMode)
                SaveControlTree(form);

            ApplyToControlTree(form, IsDarkMode);
        }


        private static void UpdateAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
                ApplyToControlTree(f, IsDarkMode);
        }

        private static void SaveAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
                SaveControlTree(f);
        }

        private static void RestoreAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
                ApplyToControlTree(f, isDark: false);
        }


        //Рекурсивно сохраняет исходные цвета контрола и его потомков
        private static void SaveControlTree(Control control)
        {
            if (!OriginalColors.ContainsKey(control))
                OriginalColors[control] = (control.BackColor, control.ForeColor);

            foreach (Control child in control.Controls)
                SaveControlTree(child);
        }

        //Рекурсивно применяет тему (тёмную или светлую) к контролу и всем потомкам
        private static void ApplyToControlTree(Control control, bool isDark)
        {
            ApplyToSingleControl(control, isDark);

            foreach (Control child in control.Controls)
                ApplyToControlTree(child, isDark);
        }

        // Применить тему к одному контролу (без обхода потомков)
        private static void ApplyToSingleControl(Control control, bool isDark)
        {
            Type type = control.GetType();

            // 1. Кастомный обработчик имеет приоритет
            if (CustomHandlers.TryGetValue(type, out var handler))
            {
                handler(control, isDark);
                return;
            }

            // 2. Стандартное поведение
            if (isDark)
            {
                (Color back, Color fore) = TryGetOriginal(control);
                control.BackColor = Darken(back, _darkFactor);
                control.ForeColor = Lighten(fore, _lightFactor);
            }
            else
            {
                // Светлая тема – восстанавливаем исходные цвета, если они есть
                if (OriginalColors.TryGetValue(control, out var original))
                {
                    control.BackColor = original.Back;
                    control.ForeColor = original.Fore;
                }
            }
        }

        // Получить сохранённый исходный цвет или глобальный стандарт
        private static (Color Back, Color Fore) TryGetOriginal(Control control)
        {
            return OriginalColors.TryGetValue(control, out var original)
                ? original
                : (DefaultBackColor, DefaultForeColor);
        }

        private static Color Darken(Color color, double factor)
        {
            factor = Math.Max(0, Math.Min(1, factor));
            return Color.FromArgb(
                (int)(color.R * (1 - factor)),
                (int)(color.G * (1 - factor)),
                (int)(color.B * (1 - factor)));
        }

        private static Color Lighten(Color color, double factor)
        {
            factor = Math.Max(0, Math.Min(1, factor));
            return Color.FromArgb(
                (int)(color.R + (255 - color.R) * factor),
                (int)(color.G + (255 - color.G) * factor),
                (int)(color.B + (255 - color.B) * factor));
        }

        private static void ApplyChartTheme(Chart chart, bool isDark)
        {
            Color back = isDark ? Color.FromArgb(30, 30, 30) : Color.White;
            Color fore = isDark ? Color.LightGray : Color.Black;

            chart.BackColor = back;

            foreach (ChartArea area in chart.ChartAreas)
            {
                area.BackColor = back;
                area.AxisX.LabelStyle.ForeColor = fore;
                area.AxisY.LabelStyle.ForeColor = fore;
                area.AxisX.TitleForeColor = fore;
                area.AxisY.TitleForeColor = fore;
                area.AxisX.MajorGrid.LineColor = fore;
                area.AxisY.MajorGrid.LineColor = fore;
                area.AxisX.LineColor = isDark ? Color.Gray : Color.Black;
                area.AxisY.LineColor = isDark ? Color.Gray : Color.Black;
            }

            foreach (Legend legend in chart.Legends)
            {
                legend.BackColor = back;
                legend.ForeColor = fore;
            }

            foreach (Title title in chart.Titles)
                title.ForeColor = fore;
        }
    }
}
