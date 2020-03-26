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
    class edit_queue_controller
    {
        data_holder memory = data_holder.Instance;
        Edit_Queue main;
        public edit_queue_controller(Edit_Queue main)
        {
            this.main = main;
            enable_checker();
        }
        void enable_checker()
        {
            if (!main.TF_description.Text.Equals(main.description))
            {
                new button_action(main.BT_update, true);
            } else
            {
                new button_action(main.BT_update, false);
            }
        }
        public void type_into_description_listener(object sender, KeyEventArgs e)
        {
            enable_checker();
        }
        public void back(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new Queues_Panel().MainPanel);
        }
    }
}
