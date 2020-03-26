using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    public partial class queue_items : Form
    {
        string id = null;
        public queue_items(String id, String queue_name)
        {
            this.id = id;
            InitializeComponent();
            label_queue_name.Text = queue_name;
            Self_init();
        }
        void Self_init()
        {
            attach_model_data();
        }
        void attach_model_data()
        {
            foreach (var item in DBQueries.QueueItems(id))
            {
                queue_list.Height = queue_list.Height + new queue_item_list2().main_panel.Height;
            }

            int count = 0;
            foreach (var item in DBQueries.QueueItems(id))
            {
                queue_item_list2 queueListItem = new queue_item_list2();
                queueListItem.set_data(
                    item.ID, 
                    item.StatusID, 
                    item.Reference, 
                    item.Priority, 
                    item.CreationTime.ToString(), 
                    item.StartTime.ToString(), 
                    item.EndTime.ToString()
                    );
                Panel panel = queueListItem.main_panel;
                panel.Location = new Point(0, panel.Height * count);
                queue_list.Controls.Add(panel);
                new size_listener(queue_list, panel, panel.Height, 0);
                count++;
            }
        }
    }
}
