using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class add_to_queue_controller
    {
        data_holder memory = data_holder.Instance;
        Add_To_Queue_Panel main;
        public add_to_queue_controller(Add_To_Queue_Panel main)
        {
            this.main = main;
        }
        public void add(object sender, EventArgs e)
        {
            Queues queue = new Queues();
            queue.NAME = main.TF_queue_panel.Text;
            queue.Desc = main.TF_queue_panel.Text;

            new DBQueries().AddNewQueue(queue);
            new set_panel_changer(memory.GetPanelChanger(), new Queues_Panel().MainPanel);
        }
        public void cancel(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new Queues_Panel().MainPanel);
        }
    }
}
