using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1
{
    public partial class Schedule_Panel : Form
    {
        schedule_panel_controller controller;
        data_holder memory = data_holder.Instance;
        public Schedule_Panel()
        {
            InitializeComponent();
            controller = new schedule_panel_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            new set_button_invisible(BT_add_schedule, System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\plus-circle.png"));
            BT_add_schedule.Text = null;
            BT_add_schedule.Click += new EventHandler(controller.AddScheduleClick);
            new create_rounded_button(BT_add_schedule);
            attach_model_data();
        }
        public void attach_model_data()
        {
            int schedCount = DBQueries.getAllSchedule().Count;
            int count = 0;
            panel_schedule_list.Controls.Clear();
            foreach (var item in DBQueries.getAllSchedule())
            {
                schedule_list schedule_list = new schedule_list();
                schedule_list.set_data(
                    item.id, 
                    item.schedule_name, 
                    item.robot_name, 
                    item.schedule_day, 
                    item.schedule_day,
                    item.should_enable,
                    this
                );
                if (count == schedCount - 1)
                {
                    schedule_list.panel_bottom_border.Visible = true;
                }
                Panel panel = schedule_list.main_panel;
                panel.Width = panel_schedule_list.Width;
                panel.Location = new Point(0, panel.Height * count);
                panel_schedule_list.Controls.Add(panel);
                new size_listener(this.panel_schedule_list, panel, panel.Height, 0);
                panel_schedule_list.Height = panel_schedule_list.Height + panel.Height;
                count++;
            }
        }
    }
}
