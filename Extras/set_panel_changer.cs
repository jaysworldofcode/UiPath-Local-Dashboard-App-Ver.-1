using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class set_panel_changer
    {
        public set_panel_changer(Control main, Control change)
        {
            main.Controls.Clear();
            change.Size = new Size(
                main.Width,
                main.Height);
            main.Controls.Add(change);
        }
    }
}
