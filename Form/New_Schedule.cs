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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class New_Schedule : Form
    {
        robot_model model = new robot_model();
        new_schedule_controller controller;
        public New_Schedule()
        {
            InitializeComponent();
            controller = new new_schedule_controller(this);
            Self_init();
        }
        void Self_init()
        {
            BT_add_schedule.Click += new EventHandler(controller.AddPress);
            BT_Cancel.Click += new EventHandler(controller.CancelPress);
            CB_robot_list.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemRobot();
        }
        public void Set_asEdit(
            int id, String ScheduleName,
            String RobotName,
            String ScheduleDay,
            String ScheduleTime)
        {
            TF_schedule_name.Text = ScheduleName;

            CB_robot_list.SelectedItem = RobotName;

            if (ScheduleDay.Contains("SUN")) { CB_sunday.Checked = true; }
            if (ScheduleDay.Contains("MON")) { CB_monday.Checked = true; }
            if (ScheduleDay.Contains("TUE")) { CB_tuesday.Checked = true; }
            if (ScheduleDay.Contains("WED")) { CB_wednesday.Checked = true; }
            if (ScheduleDay.Contains("THU")) { CB_thursday.Checked = true; }
            if (ScheduleDay.Contains("FRI")) { CB_friday.Checked = true; }
            if (ScheduleDay.Contains("SAT")) { CB_saturday.Checked = true; }

            TF_hour.Text = ScheduleTime.Split(":".ToCharArray())[0];
            TF_minute.Text = ScheduleTime.Split(":".ToCharArray())[1];

            BT_add_schedule.Text = "UPDATE";
        }
        void AddItemRobot()
        {
            for (int count=0; count < model.GetRobot_Name().Count; count++)
                CB_robot_list.Items.Add(model.GetRobot_Name()[count]);
        }
    }
}