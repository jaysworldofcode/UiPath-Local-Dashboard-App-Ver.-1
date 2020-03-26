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
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1
{
    public partial class queues_list : Form
    {
        data_holder memory = data_holder.Instance;
        queues_list_controller controller;
        public Boolean isUniqueReference;
        public int total_retry;
        public String total_in_progress;
        public String total_successful;
        public String total_fail;
        public String queue_id;
        public queues_list()
        {
            InitializeComponent();
            Self_Init();
        }
        void Self_Init()
        {
            controller = new queues_list_controller(this);
            BT_settings.Click += new EventHandler(controller.settings_click);
            BT_settings.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath()+ "\\Image\\menu.png");
            BT_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            new create_rounded_button(BT_settings);

            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count = 0; count < main_panel.Controls.Count; count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
        }
        public void SetLabelPadding()
        {
            int set_padding_left = main_panel.Width / 40;
            label_in_progress.Padding = new Padding(set_padding_left, 0, 0, 0);
            label_successful.Padding = new Padding(set_padding_left, 0, 0, 0);
            label_fail.Padding = new Padding(set_padding_left, 0, 0, 0);
        }
        public void set_data(
            String queue_id,
            String queue_name,
            String queue_description,
            String total_in_progress,
            String total_successful,
            Boolean isUniqueReference,
            String total_fail,
            int total_retry)
        {
            this.queue_id = queue_id;
            this.total_in_progress = total_in_progress;
            this.total_successful = total_successful;
            this.total_fail = total_fail;
            label_queue_name.Text = queue_name;
            label_description.Text = queue_description;
            label_in_progress.Text = "NEW (" + total_in_progress + ")";
            label_successful.Text = "SUCCESS (" + total_successful + ")";
            label_fail.Text = "FAIL (" + total_fail + ")";
            this.isUniqueReference = isUniqueReference;
            this.total_retry = total_retry;
        }
    }
}
