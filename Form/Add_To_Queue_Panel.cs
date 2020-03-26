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
    public partial class Add_To_Queue_Panel : Form
    {
        add_to_queue_controller controller;
        public Add_To_Queue_Panel()
        {
            InitializeComponent();
            Self_Init();
        }
        void Self_Init()
        {
            controller = new add_to_queue_controller(this);
            BT_new.Click += new EventHandler(controller.add);
            BT_Cancel.Click += new EventHandler(controller.cancel);
        }
    }
}
