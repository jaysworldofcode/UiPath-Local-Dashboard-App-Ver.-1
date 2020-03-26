using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    public partial class queue_item_list2 : Form
    {
        public queue_item_list2()
        {
            InitializeComponent();
        }
        public void set_data(int id, int status_id, string reference, string priority, string created, string started, string ended)
        {
            label_type.Text = new GetQueueItemStatusType().GetType(status_id);

            //Checnk the lenght of the reference
            label_reference.Text = (reference.Length > 10) ? reference.Substring(0, 10) + "...." : reference;
            Priority.Text = (priority.Length > 10) ? priority.Substring(0, 10) + "...." : priority;
            Created.Text = (created.Length > 10) ? created.Substring(0, 10) + "...." : created;
            Started.Text = (started.Length > 10) ? started.Substring(0, 10) + "...." : started;
            Ended.Text = (ended.Length > 10) ? ended.Substring(0, 10) + "...." : ended;
        }
    }
}
