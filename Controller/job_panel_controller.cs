using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class job_panel_controller
    {
        data_holder memory = data_holder.Instance;
        Jobs_Panel main;
        public job_panel_controller(Jobs_Panel main)
        {
            this.main = main;
        }
        public void RobotsPress(object sender, EventArgs e)
        {
            Panel packages_panel = new Packages_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), packages_panel);
            memory.menuChoosen = "robot";
        }
    }
}
