using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class set_button_invisible
    {
        public set_button_invisible(Button button, Image image)
        {
            button.Text = null;
            button.Image = image;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
    }
}
