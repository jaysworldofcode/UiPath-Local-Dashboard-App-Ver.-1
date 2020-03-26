using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class logs_controller
    {
        data_holder memory = data_holder.Instance;
        logs_panel main;
        public logs_controller(logs_panel main)
        {
            this.main = main;
        }
        public void BackPress(object sender, EventArgs e)
        {
            new set_panel_changer(
                memory.GetPanelChanger(),
                new Jobs_Panel().MainPanel
             );
        }
    }
}
