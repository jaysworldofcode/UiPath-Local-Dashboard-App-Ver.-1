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
    public partial class Edit_Queue : Form
    {
        edit_queue_controller controller;
        String queue_name;
        public String description;
        Boolean isUniqueReference;
        String maxRetries;
        public Edit_Queue(
            String queue_name,
            String description,
            Boolean isUniqueReference,
            String maxRetries)
        {
            InitializeComponent();
            this.queue_name = queue_name;
            this.description = description;
            this.isUniqueReference = isUniqueReference;
            this.maxRetries = maxRetries;
            Self_Init();
        }
        void Self_Init()
        {
            set_data();
            controller = new edit_queue_controller(this);
            TF_description.KeyUp += new KeyEventHandler(controller.type_into_description_listener);
            BT_Cancel.Click += new EventHandler(controller.back);
        }
        void set_data()
        {
            Label_QueueName.Text = "> "+ queue_name;
            TF_queue_name.Text = queue_name;
            TF_description.Text = description;
            TF_retry.Text = maxRetries;
            if (isUniqueReference)
            {
                RB_yes.Checked = true;
            } else
            {
                RB_no.Checked = true;
            }
        }
    }
}
