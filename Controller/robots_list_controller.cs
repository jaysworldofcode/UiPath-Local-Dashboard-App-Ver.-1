using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class robots_list_controller
    {
        data_holder memory = data_holder.Instance;
        robots_list main;
        ContextMenuStrip settings = new ContextMenuStrip();
        private Timer timer1;
        
        public robots_list_controller(robots_list robots_main)
        {
            this.main = robots_main;
            robots_main.main_panel.Resize += new EventHandler(Resize);

            settings.Items.Clear();
            settings.Items.Add("DETAILS");
            settings.Items.Add("DELETE");

            timer1 = new Timer();
            timer1.Interval = 200;
            timer1.Tick += show_tick;
            timer1.Enabled = true;
        }
        public void MouseEnterMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.WhiteSmoke;
        }
        public void MouseLeaveMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.White;
        }
        private void Resize(object sender, System.EventArgs e)
        {
            main.SetLabelPadding();
        }
        public void RunPress(object sender, EventArgs e)
        {
            /*pop_up_medium pop_up = new pop_up_medium();
            pop_up.SetParentForm(memory.GetTaskbarForm());
            if (pop_up.GetChoosen())
            {
                //new Run(main.label_robot.Text);
                memory.current_robot_run = main.label_robot.Text;
                new jobs_db().NewJob(
                    main.label_robot.Text,
                    DateTime.Now.ToString("yyyyMMddHHmmss"),
                    DateTime.Now.ToString(),
                    "N/A",
                    "P"
                    //memory.GetDB_conn()
                    );
             }*/
        }
        public void settings_click(object sender, EventArgs e)
        {
            settings.Show(main.BT_settings, new Point(0, main.BT_settings.Height - 10));
        }
        private void show_tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("UiPath.Executor").Length > 0)
            {
                main.BT_run.Enabled = false;
                main.BT_run.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath()+ "\\Image\\play-button-disable.png");
            } else
            {
                main.BT_run.Enabled = true;
                main.BT_run.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\play-button-enable.png");
            }
        }
    }
}
