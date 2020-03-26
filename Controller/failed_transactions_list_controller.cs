using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class failed_transactions_list_controller
    {
        data_holder memory = data_holder.Instance;
        failed_transactions_list main;
        public failed_transactions_list_controller(failed_transactions_list main)
        {
            this.main = main;
        }
        public void SolvePress(object sender, EventArgs e)
        {
            pop_up_medium pop_up = new pop_up_medium();
            pop_up.SetParentForm(memory.GetTaskbarForm());
            if (pop_up.GetChoosen())
            {
                Console.WriteLine(main.label_queue_identifier.Text+" is set as solve....");
            }      
         }
        public void MouseEnterMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.WhiteSmoke;
        }
        public void MouseLeaveMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.White;
        }
    }
}
