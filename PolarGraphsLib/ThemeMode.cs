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

        public static Color LightBack = SystemColors.Control;
        public static Color LightFore = SystemColors.ControlText;

        // Текущие цвета
        public static Color CurrentBack = LightBack;
        public static Color CurrentFore = LightFore;

        // Типы контролов, которые не трогаем
        private static readonly HashSet<Type> SkipTypes = new HashSet<Type>
        {
            typeof(PictureBox),
            // typeof(Chart)  // если нужно, раскомментируй и добавь using
        };

        private static Dictionary<Control, (Color Back, Color Fore)> OriginalColors = new Dictionary<Control, (Color Back, Color Fore)> ();

        public static bool IsDarkMode { get; private set; }

        public static void SetLight()
        {
            IsDarkMode = false;
            // Восстанавливаем исходные цвета из словаря, а не из глобальных LightBack/LightFore
            RestoreOriginalColors();
        }

        public static void SetDark(double darkFactor = 0.75, double lightFactor = 0.9)
        {
            IsDarkMode = true;
            // Перед затемнением в первый раз — запомнить текущие цвета всех открытых форм
            if (OriginalColors.Count == 0)
                SaveOriginalColors();

            CurrentBack = Darken(LightBack, darkFactor);
            CurrentFore = Lighten(LightFore, lightFactor);
            UpdateAllOpenForms();
        }

        // Применить тему к форме (вызывается из конструктора)
        public static void Apply(Form form)
        {
            // Если тёмная тема уже активна — принудительно применяем тёмные цвета к новой форме
            if (IsDarkMode)
            {
                ApplyToControlDark(form);
            }
            // Если светлая — оставляем как есть (изначальные цвета из дизайнера)
        }

        // Сохранить исходные цвета всех контролов на всех открытых формах
        private static void SaveOriginalColors()
        {
            foreach (Form f in Application.OpenForms)
                SaveControlColors(f);
        }

        private static void SaveControlColors(Control ctrl)
        {
            if (!OriginalColors.ContainsKey(ctrl))
                OriginalColors[ctrl] = (ctrl.BackColor, ctrl.ForeColor);

            foreach (Control child in ctrl.Controls)
                SaveControlColors(child);
        }

        // Восстановить исходные цвета всем открытым формам
        private static void RestoreOriginalColors()
        {
            foreach (Form f in Application.OpenForms)
                RestoreControlColors(f);
        }

        private static void RestoreControlColors(Control ctrl)
        {
            if (OriginalColors.TryGetValue(ctrl, out var colors))
            {
                ctrl.BackColor = colors.Back;
                ctrl.ForeColor = colors.Fore;
            }
            foreach (Control child in ctrl.Controls)
                RestoreControlColors(child);
        }

        // Принудительное применение тёмной темы к новой форме
        private static void ApplyToControlDark(Control ctrl)
        {
            // Сохраняем исходные цвета для новой формы перед заменой
            SaveControlColors(ctrl);
            // Теперь применяем тёмные вычисленные цвета
            ctrl.BackColor = Darken(LightBack, 0.75); // или используй CurrentBack, но лучше вычислять из исходного
            ctrl.ForeColor = Lighten(LightFore, 0.9);
            foreach (Control child in ctrl.Controls)
                ApplyToControlDark(child);
        }

        // Обновить все открытые формы
        private static void UpdateAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
            {
                ApplyToControl(f);
            }
        }

        // Рекурсивно задаём цвета, пропуская ненужные контролы
        private static void ApplyToControl(Control ctrl)
        {
           /* if (SkipTypes.Contains(ctrl.GetType()))
                return;*/

            ctrl.BackColor = CurrentBack;
            ctrl.ForeColor = CurrentFore;

            foreach (Control child in ctrl.Controls)
                ApplyToControl(child);
        }

        // Вспомогательные методы для цвета
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








        /*
        public static Color DefaultLightBack = SystemColors.Control;
        public static Color DefaultLightFore = SystemColors.ControlText;

        // Типы контролов, которые не обрабатываются совсем
        public static readonly HashSet<Type> SkipTypes = new HashSet<Type>
    {
        typeof(PictureBox),
        // typeof(Chart) – для него мы сделаем кастомный обработчик
    };

        // Словарь: тип контрола -> Action(Control, bool isDark)
        public static readonly Dictionary<Type, Action<Control, bool>> CustomHandlers =
            new Dictionary<Type, Action<Control, bool>>();

        // Хранилище исходных (светлых) цветов для каждого контрола
        private static readonly Dictionary<Control, (Color Back, Color Fore)> OriginalColors =
            new Dictionary<Control, (Color Back, Color Fore)>();

        // Параметры затемнения/осветления (задаются при SetDark)
        private static double _darkFactor = 0.75;
        private static double _lightFactor = 0.9;

        public static bool IsDarkMode { get; private set; } = false;

        // =================== Публичные методы ===================

        /// <summary>Переключиться на светлую тему (восстанавливает исходные цвета).</summary>
        public static void SetLight()
        {
            IsDarkMode = false;
            RestoreOriginalColors();
            OriginalColors.Clear();   // для следующего SetDark сохраним заново
        }

        /// <summary>
        /// Переключиться на тёмную тему.
        /// </summary>
        /// <param name="darkFactor">Коэффициент затемнения фона (0 – без изменений, 1 – чёрный).</param>
        /// <param name="lightFactor">Коэффициент осветления текста (0 – без изменений, 1 – белый).</param>
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

        /// <summary>
        /// Применить тему к новой форме (вызывать в конструкторе после InitializeComponent()).
        /// </summary>
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
            // Если светлая тема – ничего не делаем, форма уже отображает свои дизайнерские цвета
        }

        /// <summary>
        /// Зарегистрировать кастомный обработчик для определённого типа контрола.
        /// </summary>
        /// <param name="controlType">Тип контрола (например, typeof(Chart)).</param>
        /// <param name="handler">Метод, принимающий Control и флаг isDark.</param>
        public static void RegisterCustomHandler(Type controlType, Action<Control, bool> handler)
        {
            if (controlType == null || handler == null) return;
            CustomHandlers[controlType] = handler;
        }

        /// <summary>
        /// Пример готового обработчика для Chart. Вызовите этот метод при старте приложения.
        /// </summary>
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

        // =================== Внутренние методы ===================

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
            if (OriginalColors.TryGetValue(ctrl, out var colors))
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
            else if (!SkipTypes.Contains(t))
            {
                if (isDark)
                {
                    // Получаем исходный цвет (индивидуальный или общий запасной)
                    Color origBack = OriginalColors.TryGetValue(ctrl, out var orig) ? orig.Back : DefaultLightBack;
                    Color origFore = OriginalColors.TryGetValue(ctrl, out orig) ? orig.Fore : DefaultLightFore;

                    ctrl.BackColor = Darken(origBack, _darkFactor);
                    ctrl.ForeColor = Lighten(origFore, _lightFactor);
                }
                // Светлая тема восстанавливается не здесь, а через RestoreOriginalColors
            }

            // Рекурсивный обход дочерних контролов
            foreach (Control child in ctrl.Controls)
                ApplyToControl(child, isDark);
        }

        // =================== Утилиты для работы с цветом ===================

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
        }*/
    }
}
