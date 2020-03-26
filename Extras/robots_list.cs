using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    public partial class robots_list : Form
    {
        data_holder memory = data_holder.Instance;
        robots_list_controller controller;
        int RobotID;
        String RobotName;
        String RobotDescription;
        String RobotCurrentVersion;
        String RobotPublishedDate;

        public robots_list()
        {
            InitializeComponent();
            controller = new robots_list_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            BT_run.Click += new EventHandler(controller.RunPress);
            BT_settings.Click += new EventHandler(controller.settings_click);
            BT_settings.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\menu.png");
            BT_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BT_run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BT_run.Text = null;
            new create_rounded_button(BT_run);
            new create_rounded_button(BT_settings);

            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count=0;count< main_panel.Controls.Count;count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
        }
        public void SetLabelPadding()
        {
            int set_padding_left = main_panel.Width / 60;
            label_robot.Padding = new Padding(set_padding_left, 0, 0, 0);
            label_description.Padding = new Padding(set_padding_left, 0, 0, 0);
            label_published_date.Padding = new Padding(set_padding_left, 0, 0, 0);
        }
        public void set_data(
            int RobotID,
            String RobotName,
            String RobotDescription,
            String RobotCurrentVersion,
            String RobotPublishedDate)
        {
            this.RobotID = RobotID;
            this.RobotName = RobotName;
            this.RobotDescription = RobotDescription;
            this.RobotCurrentVersion = RobotCurrentVersion;
            this.RobotPublishedDate = RobotPublishedDate;

            label_robot.Text = RobotName;
            label_description.Text = RobotCurrentVersion;
            label_published_date.Text = RobotPublishedDate;
        }
    }
}
