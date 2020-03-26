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

namespace WindowsFormsApp1.Extras
{
    public partial class schedule_list : Form
    {
        public Schedule_Panel main;
        schedule_list_controller controller;
        data_holder memory = data_holder.Instance;
        public String schedule_name;
        public String process_name;
        public String schedule_day;
        public String schedule_time;
        public String status;
        public int schedule_id;
        public schedule_list()
        {
            InitializeComponent();
            controller = new schedule_list_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            BT_status.Click += new EventHandler(controller.UpdateStatus);
            BT_edit.Click += new EventHandler(controller.EditScheduleInfo);
            BT_delete.Click += new EventHandler(controller.DeleteSchedule);
            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count = 0; count < main_panel.Controls.Count; count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
        }
        public void set_data(
            int schedule_id,
            String schedule_name,
            String process_name,
            String schedule_day,
            String schedule_time,
            String status,
            Schedule_Panel main)
        {
            this.schedule_name = schedule_name;
            this.process_name = process_name;
            this.schedule_day = schedule_day;
            this.schedule_time = schedule_time;
            this.status = status;
            this.schedule_id = schedule_id;
            this.main = main;

            label_schedule_name.Text = schedule_name;
            label_process_name.Text = process_name;
            label_schedule.Text = schedule_day + "/" + schedule_time;

            if (status.Equals("E"))
            {
                BT_status.Text = "";
                BT_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\stopwatch-disable.png");
                BT_status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                new create_rounded_button(BT_status);
            } else {
                BT_status.Text = "";
                BT_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\stopwatch-enable.png");
                BT_status.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                new create_rounded_button(BT_status);
            }

            BT_delete.Text = "";
            BT_delete.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\delete-24px.png");
            BT_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            new create_rounded_button(BT_delete);

            BT_edit.Text = "";
            BT_edit.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\pencil-24px.png");
            BT_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            new create_rounded_button(BT_edit);
        }
    }
}
