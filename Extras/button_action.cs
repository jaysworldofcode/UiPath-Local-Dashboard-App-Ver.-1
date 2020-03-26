using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class button_action
    {
        public button_action(Button button, Boolean isEnabled)
        {
            if (isEnabled)
            {
                button.BackColor = System.Drawing.Color.RoyalBlue;
                button.Enabled = true;
            } else {
                button.BackColor = System.Drawing.Color.Gray;
                button.Enabled = false;
            }
        }
    }
}
