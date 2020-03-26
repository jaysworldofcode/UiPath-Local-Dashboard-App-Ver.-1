using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class content_pop_up_controller
    {
        content_pop_up main;
        public content_pop_up_controller(content_pop_up main)
        {
            this.main = main;
        }
        public void BackPress(object sender, EventArgs e)
        {
            main.Close();
        }
    }
}
