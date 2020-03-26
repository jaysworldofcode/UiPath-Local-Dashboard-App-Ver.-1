using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Packages_Panel : Form
    {
        data_holder memory = data_holder.Instance;
        robot_model model = new robot_model();
        robot_panel_controller controller;
        public Packages_Panel()
        {
            InitializeComponent();
            controller = new robot_panel_controller(this);
            Self_init();
        }
        void Self_init()
        {
            attach_model_data();
            BT_add_robot.Text = null;
            new set_button_invisible(BT_add_robot, System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\plus-circle.png"));
            BT_add_robot.Click += new EventHandler(controller.AddRobotClick);
            new create_rounded_button(BT_add_robot);
        }
        void attach_model_data()
        {
            for (int count = 0; count < model.GetRobot_Name().Count; count++)
            {
                robots_list robot = new robots_list();
                robot.set_data(
                    Int32.Parse(model.GetRobot_ID()[count]),
                    model.GetRobot_Name()[count],
                    model.GetRobot_Description()[count],
                    model.GetRobot_CurrentVersion()[count],
                    model.GetRobot_published_date()[count]
                );
                if (count == model.GetRobot_Name().Count-1)
                {
                    robot.panel_bottom_border.Visible = true;
                }
                Panel panel = robot.main_panel;
                panel.Location = new Point(0, panel.Height * count);
                robots_list.Controls.Add(panel);
                new size_listener(robots_list, panel, panel.Height, 0);
                robots_list.Height = robots_list.Height + panel.Height;
            }
        }
    }
}
