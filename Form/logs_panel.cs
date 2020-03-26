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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Extras
{
    public partial class logs_panel : Form
    {
        logs_controller controller;
        string ProcessName;
        string job_id;
        public logs_panel(String ProcessName, String job_id)
        {
            this.ProcessName = ProcessName;
            this.job_id = job_id;
            InitializeComponent();
            controller = new logs_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            label_process_name.Text = ProcessName;
            attach_model_data();
        }
        void attach_model_data()
        {
            foreach (var item in DBQueries.loadLog(job_id))
            {
                logs_list.Height = logs_list.Height + new logs_list().main_panel.Height;
            }

            int count = 0;
            foreach (var item in DBQueries.loadLog(job_id))
            {
                logs_list main = new logs_list();
                main.SetData(item.ID.ToString(), item.Level, item.Description, item.TimeStamp);
                Panel panel = main.main_panel;
                panel.Location = new Point(0, panel.Height * count);
                logs_list.Controls.Add(panel);
                new size_listener(logs_list, panel, panel.Height, 0);
                Console.WriteLine(logs_list.Height);
                count++;
            }
        }
    }
}
