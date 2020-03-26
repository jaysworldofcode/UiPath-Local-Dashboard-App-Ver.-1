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
    public partial class failed_transactions_list : Form
    {
        failed_transactions_list_controller controller;
        String queue_identifier;
        public failed_transactions_list()
        {
            InitializeComponent();
            controller = new failed_transactions_list_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            BT_solve.Click += new EventHandler(controller.SolvePress);
            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count = 0; count < main_panel.Controls.Count; count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
        }
        public void set_data(String queue_identifier)
        {
            queue_identifier = queue_identifier;
            label_queue_identifier.Text = queue_identifier;
        }
    }
}
