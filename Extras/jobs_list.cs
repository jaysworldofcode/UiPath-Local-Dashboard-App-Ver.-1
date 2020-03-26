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

namespace WindowsFormsApp1.Extras
{    
    public partial class jobs_list : Form
    {
        jobs_list_controller controller;
        data_holder memory = data_holder.Instance;
        public String job_id;
        String robot_name;
        String trigger_added;
        public String status;
        public Color setColor;
        public jobs_list()
        {
            InitializeComponent();
            controller = new jobs_list_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            BT_info.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\info-blue-16px.png");
            BT_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            new create_rounded_button(BT_info);

            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count = 0; count < main_panel.Controls.Count; count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
            BT_view.Click += new EventHandler(controller.LogsPress);
        }
        public void set_data(
            String job_id,
            String robot_name,
            String trigger_added,
            String status)
        {
            this.job_id = job_id;
            this.robot_name = robot_name;
            this.trigger_added = trigger_added;
            this.status = status;

            label_robot.Text = robot_name;
            
            if (status.Equals("P")){
                pb_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\pending.png");
                BT_view.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\close-blue-16px.png");
                BT_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                //setColor = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
                main_panel.BackColor = setColor;
                new create_rounded_button(BT_view);
            } else if (status.Equals("R")){
                pb_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\play-16px.png");
                BT_view.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\stop-blue-16px.png");
                BT_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                //setColor = System.Drawing.ColorTranslator.FromHtml("#d7ecf5");
                main_panel.BackColor = setColor;
                new create_rounded_button(BT_view);
            } else if (status.Equals("S")){
                pb_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\success.png");
                BT_view.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\visibility-blue-16px.png");
                BT_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                //setColor = System.Drawing.ColorTranslator.FromHtml("#dcf2de");
                main_panel.BackColor = setColor;
                new create_rounded_button(BT_view);
            } else if (status.Equals("SS")){
                pb_status.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\stop-16px.png");
                BT_view.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\visibility-blue-16px.png");
                BT_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                //setColor = System.Drawing.ColorTranslator.FromHtml("#f2e4e4");
                main_panel.BackColor= setColor;
                new create_rounded_button(BT_view);
            }
            Console.WriteLine("job_id: " + job_id);
        }
    }
}