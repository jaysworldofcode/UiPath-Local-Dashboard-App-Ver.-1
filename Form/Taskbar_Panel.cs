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
    public partial class Form2 : Form
    {
        data_holder memory = data_holder.Instance;
        Taskbar_Controller controller;
        public Form2()
        {
            InitializeComponent();
            Database.CreateDatabase("Database");
            memory.SetPanelChanger(Panel_ScreenChanger);
            controller = new Taskbar_Controller(this);
            Self_Init();
        }
        public void Minimize()
        {
            Hide();
            notify_icon.Visible = true;
        }
        void Self_Init()
        {
            new DBQueries().CreateDBAndTable();
            //Set dashboard as default
            if (memory.GetDashboardPanel() == null)
            {
                memory.SetDashboardPanel(new Dashboard_Panel());
            }
            Panel dashboard_panel = memory.GetDashboardPanel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), dashboard_panel);

            notify_icon.Click += new EventHandler(controller.OpenApp);
            BT_minimize.Click += new EventHandler(controller.HideApp);
            menu_robot.Click += new EventHandler(controller.RobotsPress);
            menu_queues.Click += new EventHandler(controller.QueuePress);
            menu_assets.Click += new EventHandler(controller.AssetsPress);
            menu_jobs.Click += new EventHandler(controller.JobsPress);
            menu_schedule.Click += new EventHandler(controller.SchedulePress);
            menu_dashboard.Click += new EventHandler(controller.DashboardPress);
            panel_account_details.Click += new EventHandler(controller.settings_click);
            pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-enable.png");
            pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
            pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
            pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
            pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
            pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
            this.FormClosing += controller.FormClosing;
            PB_Profile.ImageLocation = memory.GetAssetsPath() + "\\Image\\Log2.png";
            PB_Profile.SizeMode = PictureBoxSizeMode.StretchImage;
            ChangerControlsClick();
            //Run action bar
            run_action_bar action_bar = new run_action_bar(this);
            memory.SetTaskbarForm(this);
        }
        void ChangerControlsClick()
        {
            //Set controls click for profile press
            for (int count = 0; count < panel_account_details.Controls.Count; count++)
                panel_account_details.Controls[count].Click += new EventHandler(controller.settings_click);
            //Set controls click for robot press
            for (int count = 0; count < menu_robot.Controls.Count; count++)
                menu_robot.Controls[count].Click += new EventHandler(controller.RobotsPress);
            //Set controls click for queue press
            for (int count = 0; count < menu_queues.Controls.Count; count++)
                menu_queues.Controls[count].Click += new EventHandler(controller.QueuePress);
            //Set controls click for assets press
            for (int count = 0; count < menu_assets.Controls.Count; count++)
                menu_assets.Controls[count].Click += new EventHandler(controller.AssetsPress);
            //Set controls click for view account settings press
            for (int count = 0; count < menu_assets.Controls.Count; count++)
                panel_account_details.Controls[count].Click += new EventHandler(controller.settings_click);
            //Set controls click for jobs press
            for (int count = 0; count < menu_jobs.Controls.Count; count++)
                menu_jobs.Controls[count].Click += new EventHandler(controller.JobsPress);
            //Set controls click for schedule press
            for (int count = 0; count < menu_schedule.Controls.Count; count++)
                menu_schedule.Controls[count].Click += new EventHandler(controller.SchedulePress);
            //Set controls click for dashboard press
            for (int count = 0; count < menu_dashboard.Controls.Count; count++)
                menu_dashboard.Controls[count].Click += new EventHandler(controller.DashboardPress);
        }
    }
}
