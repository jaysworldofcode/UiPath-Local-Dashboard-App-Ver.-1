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
    public partial class Queues_Panel : Form
    {
        data_holder memory = data_holder.Instance;
        Model.queue_list_model model = new Model.queue_list_model();
        queues_panel_controller controller;
        public Queues_Panel()
        {
            InitializeComponent();
            Self_init();
        }
        void Self_init()
        {
            controller = new queues_panel_controller(this);
            new set_button_invisible(BT_add_queue, System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\plus-circle.png"));
            BT_add_queue.Click += new EventHandler(controller.add_queue_click);
            BT_add_queue.Text = null;
            new create_rounded_button(BT_add_queue);
            attach_model_data();
        }
        void attach_model_data()
        {
            for(int count=0;count< model.GetQueue_name_list().Count; count++)
            {
                 queues_list queue_ui = new queues_list();
                 queue_ui.set_data(
                     model.GetQueue_id_list()[count].ToString(),
                     model.GetQueue_name_list()[count],
                     model.GetQueue_description_list()[count],
                     model.GetIn_progress_list()[count],
                     model.GetSuccessful_list()[count],
                     model.GetIsUnique_reference_list()[count],
                     model.GetFail_total_list()[count],
                     model.GetTotalRetry_list()[count]
                 );
                if (count == model.GetQueue_name_list().Count - 1)
                {
                    queue_ui.panel_bottom_border.Visible = true;
                }
                Panel panel = queue_ui.main_panel;
                panel.Location = new Point(0, 62*count);
                queue_list.Controls.Add(panel);
                new size_listener(queue_list, panel, 62, 0);
                queue_list.Height = queue_list.Height + panel.Height;
            }
        }
    }
}
