using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class queues_list_controller
    {
        data_holder memory = data_holder.Instance;
        ContextMenuStrip settings = new ContextMenuStrip();
        queues_list main;
        private Timer timer1;
        public queues_list_controller(queues_list main)
        {
            this.main = main;
            main.main_panel.Resize += new EventHandler(Resize);

            settings.Items.Clear();
            settings.Items.Add("EDIT");
            settings.Items.Add("VIEW TRANSACTIONS");
            settings.Items.Add("REMOVE");

            settings.ItemClicked += new ToolStripItemClickedEventHandler(
                settings_item_click);
        }
        private void Resize(object sender, System.EventArgs e)
        {
            main.SetLabelPadding();
        }
        public void settings_click(object sender, EventArgs e)
        {
            settings.Show(main.BT_settings, new Point(-150, main. BT_settings.Height-10));
        }        
        private void settings_item_click(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "EDIT")
            {
                new set_panel_changer(memory.GetPanelChanger(), 
                new Edit_Queue(
                        main.label_queue_name.Text,
                        main.label_description.Text,
                        main.isUniqueReference,
                        main.total_retry.ToString()
                    ).MainPanel);
            }else if(e.ClickedItem.Text == "VIEW TRANSACTIONS"){
                new set_panel_changer(memory.GetPanelChanger(), new queue_items(
                    main.queue_id,
                    main.label_queue_name.Text).MainPanel);
            }
        }
        public void MouseEnterMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.WhiteSmoke;
            if (!memory.GetDataQueueInfo().Visible)
            {
                memory.GetDataQueueInfo().Location = new Point(Cursor.Position.X + 40, Cursor.Position.Y);
                memory.GetDataQueueInfo().Visible = true;
                memory.GetDataQueueInfo().SetPieChartData(
                    Int32.Parse(main.total_in_progress),
                    Int32.Parse(main.total_fail),
                    Int32.Parse(main.total_successful),
                    0
                );
            }
        }
        public void MouseLeaveMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.White;
            memory.GetDataQueueInfo().Hide();
        }
    }
}
