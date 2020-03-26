using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class jobs_list_controller
    {
        data_holder memory = data_holder.Instance;
        jobs_list main;
        public jobs_list_controller(jobs_list main)
        {
            this.main = main;
        }
        public void MouseEnterMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.WhiteSmoke;
        }
        public void MouseLeaveMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.White;
        }
        public void LogsPress(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), 
                new logs_panel(main.label_robot.Text, main.job_id).MainPanel);
        }
    }
}
