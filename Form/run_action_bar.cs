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

namespace WindowsFormsApp1
{
    public partial class run_action_bar : Form
    {
        data_holder memory = data_holder.Instance;
        run_action_bar_controller controller;
        Form2 task_bar;
        public run_action_bar(Form2 task_bar)
        {
            InitializeComponent();
            controller = new run_action_bar_controller(this, task_bar);
            this.task_bar = task_bar;
            Self_Init();
        }
        void Self_Init()
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            BT_stop.Click += new EventHandler(controller.StopPress);
            BT_restart.Click += new EventHandler(controller.RestartPress);
        }
    }
}
