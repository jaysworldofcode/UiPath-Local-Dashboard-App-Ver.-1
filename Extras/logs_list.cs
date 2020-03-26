using Newtonsoft.Json;
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

namespace WindowsFormsApp1.Extras
{
public partial class logs_list : Form
    {
        String log_id;
        String level;
        String description;
        String timestamp;
        public String json;
        logs_list_controller controller;
        public logs_list()
        {
            controller = new logs_list_controller(this);
            InitializeComponent();
            Self_Init();
        }
        void Self_Init()
        {
            BT_view.Click += new EventHandler(controller.OpenPopup);
        }
        public void SetData(
            String log_id,
            String level,
            String description,
            String timestamp)
        {
            Logs logs = new Logs();
            logs.ID = Convert.ToInt32(log_id);
            logs.JobID = "";
            logs.Description = description;
            logs.Level = level;
            logs.TimeStamp = timestamp;
            json = JsonConvert.SerializeObject(logs, Formatting.Indented);

            this.log_id = log_id;
            this.level = level;
            this.description = description;
            this.timestamp = timestamp;

            label_description.Text = description;
            label_timestamp.Text = timestamp;
            label_type.Text = level;

            switch (level.ToUpper())
            {
                case "WARN":
                    label_type.BackColor = Color.Gray;
                    break;
                case "INFO":
                    label_type.BackColor = Color.DodgerBlue;
                    break;
                case "ERROR":
                    label_type.BackColor = Color.Red;
                    break;
                case "FATAL":
                    label_type.BackColor = Color.Firebrick;
                    break;
                case "TRACE":
                    label_type.BackColor = Color.Gold;
                    break;
            }
        }
    }
}
