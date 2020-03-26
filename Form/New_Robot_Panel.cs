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
    public partial class New_Robot_Panel : Form
    {
        data_holder memory = data_holder.Instance;
        robot_add_controller controller;
        public New_Robot_Panel()
        {
            InitializeComponent();
            controller = new robot_add_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            BT_Browse.Image = System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\folder-white.png");
            BT_add_robot.Click += new EventHandler(controller.AddClick);
            BT_Cancel.Click += new EventHandler(controller.CancelClick);
            BT_Browse.Click += new EventHandler(controller.BrowseClick);
        }
    }
}
