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
        public static Color DefaultLightBack = SystemColors.Control;
        public static Color DefaultLightFore = SystemColors.ControlText;

        // Словарь: тип контрола -> Action(Control, bool isDark)
        public static readonly Dictionary<Type, Action<Control, bool>> CustomHandlers = new Dictionary<Type, Action<Control, bool>>();
        // Хранилище исходных (светлых) цветов для каждого контрола
        private static readonly Dictionary<Control, (Color Back, Color Fore)> OriginalColors = new Dictionary<Control, (Color Back, Color Fore)>();

        // Параметры затемнения/осветления (задаются при SetDark)
        private static double _darkFactor = 0.75;
        private static double _lightFactor = 0.9;

        public static bool IsDarkMode { get; private set; } = false;

        // Переключиться на светлую тему (восстанавливает исходные цвета)
        public static void SetLight()
        {
            IsDarkMode = false;
            RestoreOriginalColors();
            OriginalColors.Clear();
        }

        // Переключиться на тёмную тему
        public static void SetDark(double darkFactor = 0.75, double lightFactor = 0.9)
        {
            _darkFactor = Math.Max(0, Math.Min(1, darkFactor));
            _lightFactor = Math.Max(0, Math.Min(1, lightFactor));

            // Первый раз сохраняем реальные цвета всех открытых форм
            if (OriginalColors.Count == 0)
                SaveOriginalColors();

            IsDarkMode = true;
            UpdateAllOpenForms(isDark: true);
        }
        public static void Apply(Form form)
        {
            if (form == null) return;

            if (IsDarkMode)
            {
                // Сохраняем её исходные цвета, если ещё не сохранены
                SaveControlColors(form);
                // Применяем тёмную тему
                ApplyToControl(form, isDark: true);
            }
        }
        
        public static void RegisterCustomHandler(Type controlType, Action<Control, bool> handler)
        {
            if (controlType == null || handler == null) return;
            CustomHandlers[controlType] = handler;
        }

        public static void RegisterChartHandler()
        {
            RegisterCustomHandler(typeof(Chart), (ctrl, isDark) =>
            {
                var chart = ctrl as Chart;
                if (chart == null) return;

                if (isDark)
                {
                    chart.BackColor = Color.FromArgb(30, 30, 30);
                    foreach (ChartArea area in chart.ChartAreas)
                    {
                        area.BackColor = Color.FromArgb(30, 30, 30);
                        area.AxisX.LabelStyle.ForeColor = Color.LightGray;
                        area.AxisY.LabelStyle.ForeColor = Color.LightGray;
                        area.AxisX.TitleForeColor = Color.LightGray;
                        area.AxisY.TitleForeColor = Color.LightGray;
                        area.AxisX.MajorGrid.LineColor = Color.Gray;
                        area.AxisY.MajorGrid.LineColor = Color.Gray;
                        area.AxisX.LineColor = Color.Gray;
                        area.AxisY.LineColor = Color.Gray;
                    }
                    foreach (Legend legend in chart.Legends)
                    {
                        legend.BackColor = Color.FromArgb(30, 30, 30);
                        legend.ForeColor = Color.LightGray;
                    }
                    foreach (Title title in chart.Titles)
                        title.ForeColor = Color.LightGray;
                }
                else // Светлая тема – возвращаем исходные (можно сохранить оригиналы в Tag)
                {
                    chart.BackColor = DefaultLightBack;
                    foreach (ChartArea area in chart.ChartAreas)
                    {
                        area.BackColor = Color.White;
                        area.AxisX.LabelStyle.ForeColor = Color.Black;
                        area.AxisY.LabelStyle.ForeColor = Color.Black;
                        area.AxisX.TitleForeColor = Color.Black;
                        area.AxisY.TitleForeColor = Color.Black;
                        area.AxisX.MajorGrid.LineColor = Color.LightGray;
                        area.AxisY.MajorGrid.LineColor = Color.LightGray;
                        area.AxisX.LineColor = Color.Black;
                        area.AxisY.LineColor = Color.Black;
                    }
                    foreach (Legend legend in chart.Legends)
                    {
                        legend.BackColor = Color.White;
                        legend.ForeColor = Color.Black;
                    }
                    foreach (Title title in chart.Titles)
                        title.ForeColor = Color.Black;
                }
            });
        }

        // Обходит все открытые формы и применяет текущую тему (isDark = true)
        private static void UpdateAllOpenForms(bool isDark)
        {
            foreach (Form f in Application.OpenForms)
                ApplyToControl(f, isDark);
        }

        // Сохраняет исходные цвета всех открытых форм
        private static void SaveOriginalColors()
        {
            foreach (Form f in Application.OpenForms)
                SaveControlColors(f);
        }

        // Рекурсивно сохраняет цвета контрола и его потомков, если они ещё не сохранены
        private static void SaveControlColors(Control ctrl)
        {
            if (!OriginalColors.ContainsKey(ctrl))
                OriginalColors[ctrl] = (ctrl.BackColor, ctrl.ForeColor);

            foreach (Control child in ctrl.Controls)
                SaveControlColors(child);
        }

        // Восстанавливает исходные цвета на всех открытых формах
        private static void RestoreOriginalColors()
        {
            foreach (Form f in Application.OpenForms)
                RestoreControlColors(f);
        }

        // Рекурсивно восстанавливает цвет контрола из словаря, если он там есть
        private static void RestoreControlColors(Control ctrl)
        {
            Type t = ctrl.GetType();

            // Если есть кастомный обработчик, вызываем его для светлой темы (false)
            if (CustomHandlers.TryGetValue(t, out var handler))
            {
                handler(ctrl, false);
            }
            else if (OriginalColors.TryGetValue(ctrl, out var colors))
            {
                ctrl.BackColor = colors.Back;
                ctrl.ForeColor = colors.Fore;
            }

            foreach (Control child in ctrl.Controls)
                RestoreControlColors(child);
        }

        // Рекурсивное применение темы к контролу и его потомкам
        private static void ApplyToControl(Control ctrl, bool isDark)
        {
            Type t = ctrl.GetType();

            // Если есть кастомный обработчик, вызываем только его (но всё равно идём вглубь)
            if (CustomHandlers.TryGetValue(t, out var handler))
            {
                handler(ctrl, isDark);
            }
            else 
            {
                if (isDark)
                {
                    // Получаем исходный цвет (индивидуальный или общий запасной)
                    Color origBack = OriginalColors.TryGetValue(ctrl, out var orig) ? orig.Back : DefaultLightBack;
                    Color origFore = OriginalColors.TryGetValue(ctrl, out orig) ? orig.Fore : DefaultLightFore;

                    ctrl.BackColor = Darken(origBack, _darkFactor);
                    ctrl.ForeColor = Lighten(origFore, _lightFactor);
                }
            }

            // Рекурсивный обход дочерних контролов
            foreach (Control child in ctrl.Controls)
                ApplyToControl(child, isDark);
        }

        private static Color Darken(Color c, double factor)
        {
            factor = Math.Max(0, Math.Min(1, factor));
            return Color.FromArgb(
                (int)(c.R * (1 - factor)),
                (int)(c.G * (1 - factor)),
                (int)(c.B * (1 - factor)));
        }

        private static Color Lighten(Color c, double factor)
        {
            factor = Math.Max(0, Math.Min(1, factor));
            return Color.FromArgb(
                (int)(c.R + (255 - c.R) * factor),
                (int)(c.G + (255 - c.G) * factor),
                (int)(c.B + (255 - c.B) * factor));
        }
    }
}
