using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class schedule_panel_controller
    {
        data_holder memory = data_holder.Instance;
        Schedule_Panel main;
        public schedule_panel_controller(Schedule_Panel main)
        {
            this.main = main;
        }
        public void AddScheduleClick(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new New_Schedule().MainPanel);
        }
    }
}
