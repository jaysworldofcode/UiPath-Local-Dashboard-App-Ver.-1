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
    class queues_panel_controller
    {
        Queues_Panel queues_panel_main;
        data_holder memory = data_holder.Instance;
        public queues_panel_controller(Queues_Panel queues_panel_main)
        {
            this.queues_panel_main = queues_panel_main;
        }
        public void add_queue_click(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new Add_To_Queue_Panel().MainPanel);
        }
    }
}
