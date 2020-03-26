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
    class schedule_list_controller
    {
        data_holder memory = data_holder.Instance;
        schedule_list main;
        public schedule_list_controller(schedule_list main)
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
        public void UpdateStatus(object sender, EventArgs e)
        {
                String setStatus = null;
                if (main.status.Equals("E"))
                {
                    setStatus = "D";
                } else {
                    setStatus = "E";
                }

                new schedule_db().UpdateScheduleStatus(
                    setStatus,
                    main.schedule_id
                );
                memory.RetrieveScheduleModel();
                main.main.attach_model_data();
        }
        public void DeleteSchedule(object sender, EventArgs e)
        {
            pop_up_medium pop_up = new pop_up_medium();
            pop_up.SetParentForm(memory.GetTaskbarForm());
            if (pop_up.GetChoosen())
            {
                new schedule_db().DeleteSchedule(
                    main.schedule_id
                );
                memory.RetrieveScheduleModel();
                main.main.attach_model_data();
            }
        }
        public void EditScheduleInfo(object sender, EventArgs e)
        {
            New_Schedule new_schedule = new New_Schedule();
            new_schedule.Set_asEdit(
                main.schedule_id,
                main.schedule_name,
                main.process_name,
                main.schedule_day,
                main.schedule_time
            );
            Panel schedule_panel = new_schedule.MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), schedule_panel);
        }
    }
}
