using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Jobs_Panel : Form
    {
        data_holder memory = data_holder.Instance;
        job_panel_controller controller;
        public Jobs_Panel()
        {
            InitializeComponent();
            controller = new job_panel_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            attach_model_data();
            new set_button_invisible(BT_run_job, System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\play-64px.png"));
            BT_run_job.Text = null;
            new create_rounded_button(BT_run_job);
            BT_run_job.Click += new EventHandler(controller.RobotsPress);
        }
        void attach_model_data()
        {
            int count = 0;
            foreach (var item in DBQueries.GetJobs())
            {
                jobs_list jobs_ui = new jobs_list();
                jobs_ui.set_data(item.Value, item.ProcessName, item.DateTimeStart, item.Status);
                if (count == DBQueries.GetJobs().Count - 1)
                {
                    jobs_ui.panel_bottom_border.Visible = true;
                }
                Panel panel = jobs_ui.main_panel;
                panel.Location = new Point(0, panel.Height * count);
                jobs_list.Controls.Add(panel);
                new size_listener(jobs_list, panel, panel.Height, 0);
                jobs_list.Height = jobs_list.Height + panel.Height;
                count++;
            }           
        }
    }
}
