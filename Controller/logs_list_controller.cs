using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class logs_list_controller
    {
        data_holder memory = data_holder.Instance;
        logs_list main;
        public logs_list_controller(logs_list main)
        {
            this.main = main;
        }
        public void OpenPopup(object sender, EventArgs e)
        {
            content_pop_up pop_up = new content_pop_up(main.json);
            pop_up.SetParentForm(memory.GetTaskbarForm());
        }
    }
}
