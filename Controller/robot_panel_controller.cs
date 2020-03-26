using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class robot_panel_controller
    {
        data_holder memory = data_holder.Instance;
        Packages_Panel main;
        public robot_panel_controller(Packages_Panel main)
        {
            this.main = main;
        }
        public void AddRobotClick(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new New_Robot_Panel().MainPanel);
        }
    }
}
    