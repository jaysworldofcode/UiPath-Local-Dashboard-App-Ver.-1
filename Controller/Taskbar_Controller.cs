using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class Taskbar_Controller
    {
        data_holder memory = data_holder.Instance;
        ContextMenuStrip settings = new ContextMenuStrip();
        Form2 main;
        private Timer timer1;

        public Taskbar_Controller(Form2 main)
        {
            this.main = main;
            //new size_listener(memory.GetPanelChanger(), queue_panel, 0, 0);

            settings.Items.Clear();
            settings.Items.Add("My Account");
            settings.Items.Add("Change Password");
            settings.Items.Add("Accounts");
            settings.Items.Add("Log-out");

            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += show_tick;
            timer1.Enabled = true;
        }
        public void FormClosing(Object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public void HideApp(object sender, EventArgs e)
        {
            main.Minimize();
        }
        public void OpenApp(object sender, EventArgs e)
        {
            main.Show();
        }
        public void settings_click(object sender, EventArgs e)
        {
            settings.Show(main.panel_account_details, new Point(150, main.panel_account_details.Height - 40));
        }
        public void QueuePress(object sender, EventArgs e)
        {
            Panel queue_panel = new Queues_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), queue_panel);
            memory.menuChoosen = "queues";
        }
        public void DashboardPress(object sender, EventArgs e)
        {
            if (memory.GetDashboardPanel() == null)
            {
                memory.SetDashboardPanel(new Dashboard_Panel());
            }
            Panel dashboard_panel = memory.GetDashboardPanel().MainPanel;

            new set_panel_changer(memory.GetPanelChanger(), dashboard_panel);
            memory.menuChoosen = "dashboard";
        }
        public void AssetsPress(object sender, EventArgs e)
        {
            Panel assets_panel = new Assets_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), assets_panel);
            memory.menuChoosen = "assets";
        }
        public void RobotsPress(object sender, EventArgs e)
        {
            Panel packages_panel = new Packages_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), packages_panel);
            memory.menuChoosen = "robot";
        }
        public void JobsPress(object sender, EventArgs e)
        {
            Panel jobs_panel = new Jobs_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), jobs_panel);
            memory.menuChoosen = "jobs";
        }
        public void SchedulePress(object sender, EventArgs e)
        {
            Panel schedule_panel = new Schedule_Panel().MainPanel;
            new set_panel_changer(memory.GetPanelChanger(), schedule_panel);
            memory.menuChoosen = "schedule";
        }
        String lastMenu = "";
        private void show_tick(object sender, EventArgs e)
        {
            new task_bar_menu_hover(main.menu_robot);
            new task_bar_menu_hover(main.menu_queues);
            new task_bar_menu_hover(main.menu_assets);
            new task_bar_menu_hover(main.menu_dashboard);
            new task_bar_menu_hover(main.menu_schedule);
            new task_bar_menu_hover(main.menu_jobs);
            new task_bar_menu_hover(main.panel_account_details);
            if (!lastMenu.Equals(memory.menuChoosen))
            {
                menu_select(memory.menuChoosen);
            }
            lastMenu = memory.menuChoosen;
        }
        void menu_select(String selected)
        {
            if (selected.Equals("robot"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-gray.png");
                main.label_robot.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-choosen.png");
                main.label_queue.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
                main.label_jobs.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
                main.label_assets.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
                main.label_schedule.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
                main.side_chooser_dashboard.Visible = false;
                main.side_chooser_robot.Visible = true;
                main.side_chooser_queues.Visible = false;
                main.side_chooser_jobs.Visible = false;
                main.side_chooser_assets.Visible = false;
                main.side_chooser_schedule.Visible = false;
            } else if (selected.Equals("queues"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-gray.png");
                main.label_robot.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
                main.label_queue.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue-choosen.png");
                main.label_jobs.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
                main.label_assets.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
                main.label_schedule.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
                main.side_chooser_dashboard.Visible = false;
                main.side_chooser_robot.Visible = false;
                main.side_chooser_queues.Visible = true;
                main.side_chooser_jobs.Visible = false;
                main.side_chooser_assets.Visible = false;
                main.side_chooser_schedule.Visible = false;
            } else if (selected.Equals("assets"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-gray.png");
                main.label_robot.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
                main.label_queue.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
                main.label_jobs.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
                main.label_assets.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-choosen.png");
                main.label_schedule.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
                main.side_chooser_dashboard.Visible = false;
                main.side_chooser_robot.Visible = false;
                main.side_chooser_queues.Visible = false;
                main.side_chooser_jobs.Visible = false;
                main.side_chooser_assets.Visible = true;
                main.side_chooser_schedule.Visible = false;
            } else if (selected.Equals("jobs"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-gray.png");
                main.label_robot.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
                main.label_queue.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
                main.label_jobs.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-choosen.png");
                main.label_assets.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
                main.label_schedule.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
                main.side_chooser_dashboard.Visible = false;
                main.side_chooser_robot.Visible = false;
                main.side_chooser_queues.Visible = false;
                main.side_chooser_jobs.Visible = true;
                main.side_chooser_assets.Visible = false;
                main.side_chooser_schedule.Visible = false;
            } else if (selected.Equals("schedule"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-gray.png");
                main.label_robot.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
                main.label_queue.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
                main.label_jobs.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
                main.label_assets.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
                main.label_schedule.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule-choosen.png");
                main.side_chooser_dashboard.Visible = false;
                main.side_chooser_robot.Visible = false;
                main.side_chooser_queues.Visible = false;
                main.side_chooser_jobs.Visible = false;
                main.side_chooser_assets.Visible = false;
                main.side_chooser_schedule.Visible = true;
            } else if (selected.Equals("dashboard"))
            {
                main.label_dashboard.ForeColor = Color.FromArgb(0, 103, 223);
                main.pb_dashboard.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\dashboard-enable.png");
                main.label_robot.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_robot.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\robot-gray.png");
                main.label_queue.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_queue.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\queue.png");
                main.label_jobs.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_jobs.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\jobs-gray.png");
                main.label_assets.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_assets.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\assets-gray.png");
                main.label_schedule.ForeColor = Color.FromArgb(111, 110, 110);
                main.pb_schedule.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\schedule.png");
                main.side_chooser_dashboard.Visible = true;
                main.side_chooser_robot.Visible = false;
                main.side_chooser_queues.Visible = false;
                main.side_chooser_jobs.Visible = false;
                main.side_chooser_assets.Visible = false;
                main.side_chooser_schedule.Visible = false;
            }
        }
    }
}
