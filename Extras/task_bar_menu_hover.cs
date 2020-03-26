using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class task_bar_menu_hover
    {
        public task_bar_menu_hover(Control control)
        {
            if (IsInside(control))
            {
                control.BackColor = Color.Gainsboro;
            } else
            {
                control.BackColor = Color.Transparent;
            }
        }
        public bool IsInside(Control control)
        {
            Rectangle rect = new Rectangle();
            Point point = new Point();
            try
            {
                rect = control.RectangleToScreen(control.ClientRectangle);
                point = Cursor.Position;
            }
            catch (Exception ex) { }
            return rect.Contains(point);
        }
    }
}
