using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        /*private static readonly HashSet<Type> SkipTypes = new HashSet<Type>
        {
            typeof(PictureBox),
            // typeof(Chart)  // если нужно, раскомментируй и добавь using
        };*/

        public static bool IsDarkMode { get; private set; }

        // Переключить на светлую тему
        public static void SetLight()
        {
            IsDarkMode = false;
            CurrentBack = LightBack;
            CurrentFore = LightFore;
            UpdateAllOpenForms();
        }

        // Переключить на тёмную (затемнение/осветление на 90%)
        public static void SetDark(double darkFactor = 0.9, double lightFactor = 0.9)
        {
            IsDarkMode = true;
            CurrentBack = Darken(LightBack, darkFactor);
            CurrentFore = Lighten(LightFore, lightFactor);
            UpdateAllOpenForms();
        }

        // Применить тему к форме и всем её контролам
        public static void Apply(Form form)
        {
            ApplyToControl(form);
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
    }
}
