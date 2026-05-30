using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarGraphsLib
{
    public class MouseSelection : ToolStripProfessionalRenderer
    {
        public MouseSelection() : base(new DarkMenuColorTable()) { }

        // Это класс, который определяет цвета для меню
        private class DarkMenuColorTable : ProfessionalColorTable
        {
            // Цвет выделения (Вместо синего)
            //public override Color MenuItemSelected => Color.FromArgb(239, 239, 239); // Темно-серый
            //public override Color MenuItemBorder => Color.FromArgb(248, 248, 248);   // Такая же рамка

            // Опционально: поменять фон выпадающих меню на темный (как в VS)
            public override Color ToolStripDropDownBackground => Color.FromArgb(60, 60, 60);
            public override Color ImageMarginGradientBegin => Color.FromArgb(60, 60, 60);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(60, 60, 60);
            public override Color ImageMarginGradientEnd => Color.FromArgb(60, 60, 60);
        }

        // Дополнительный метод для полного контроля над отрисовкой (прозрачность/границы)
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected || e.Item.Pressed)
            {
                // Рисуем один и тот же темный фон для обоих состояний
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 248, 248, 248)), new Rectangle(Point.Empty, e.Item.Size));

                e.Graphics.DrawRectangle(Pens.LightGray, new Rectangle(Point.Empty, new Size(e.Item.Width - 1, e.Item.Height - 1)));
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Игнорируем стандартный градиент и просто закрашиваем всё в темный цвет
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), e.ToolStrip.ClientRectangle);
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Если наведена мышь (Selected == true), задаём свой цвет текста
            if (e.Item.Selected)
            {
                e.TextColor = Color.FromArgb(240, 240, 240); // Светло-серый (или любой другой)
            }
            else
            {
                // Обычный цвет текста (можно задать, например, Color.White или Color.Black)
                e.TextColor = Color.White;
            }

            // Вызываем базовый метод, чтобы текст отрисовался с нашим цветом
            base.OnRenderItemText(e);
        }
    }
}
