using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class create_rounded_button
    {
        public create_rounded_button(Button button)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, button.Width - 4, button.Height - 4);
            button.Region = new Region(p);
        }
    }
}
