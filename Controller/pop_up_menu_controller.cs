using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class pop_up_menu_controller
    {
        pop_up_medium main;
        public pop_up_menu_controller(pop_up_medium main)
        {
            this.main = main;
        }
        public void YesPress(object sender, EventArgs e)
        {
            main.isYes = true;
            main.Close();
        }
        public void NoPress(object sender, EventArgs e)
        {
            main.isYes = false;
            main.Close();
        }
    }
}
