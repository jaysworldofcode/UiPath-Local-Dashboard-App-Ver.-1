using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class new_schedule_controller
    {
        data_holder memory = data_holder.Instance;
        New_Schedule main;
        String dayChoosen;
        public new_schedule_controller(New_Schedule main)
        {
            this.main = main;
        }
        public void AddPress(object sender, EventArgs e)
        {
            pop_up_medium pop_up = new pop_up_medium();
            pop_up.SetParentForm(memory.GetTaskbarForm());
            if (pop_up.GetChoosen())
            {
                if (main.BT_add_schedule.Text.Equals("ADD"))
                {
                    if (main.CB_sunday.Checked) { dayChoosen = dayChoosen + "SUN|"; }
                    if (main.CB_monday.Checked) { dayChoosen = dayChoosen + "MON|"; }
                    if (main.CB_tuesday.Checked) { dayChoosen = dayChoosen + "TUE|"; }
                    if (main.CB_wednesday.Checked) { dayChoosen = dayChoosen + "WED|"; }
                    if (main.CB_thursday.Checked) { dayChoosen = dayChoosen + "THU|"; }
                    if (main.CB_friday.Checked) { dayChoosen = dayChoosen + "FRI|"; }
                    if (main.CB_saturday.Checked) { dayChoosen = dayChoosen + "SAT|"; }
                    dayChoosen = dayChoosen.Remove(dayChoosen.Length - 1, 1);

                    new schedule_db().AddSchedule(
                        main.TF_schedule_name.Text,
                        main.CB_robot_list.Text,
                        dayChoosen,
                        main.TF_hour.Text + ":" + main.TF_minute.Text,
                        memory.GetUsername()
                        );
                } else {

                }

                Schedule_Panel schedule = new Schedule_Panel();
                Panel schedule_panel = schedule.MainPanel;
                new set_panel_changer(memory.GetPanelChanger(), schedule_panel);
                memory.menuChoosen = "schedule";
                memory.RetrieveScheduleModel();
                schedule.attach_model_data();
            }
        }
        public void CancelPress(object sender, EventArgs e)
        {
            Panel schedule_panel = new Schedule_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), schedule_panel);
            memory.menuChoosen = "schedule";
        }
    }
}
