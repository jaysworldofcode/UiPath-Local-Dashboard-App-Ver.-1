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
    public partial class New_Assets_Panel : Form
    {
        new_assets_controller controller;
        public New_Assets_Panel()
        {
            InitializeComponent();
            controller = new new_assets_controller(this);
            Self_Init();
        }
        void Self_Init()
        {
            CB_type.SelectedIndexChanged += controller.change_type;
            BT_Add.Click += new EventHandler(controller.AddClick);
            BT_Cancel.Click += new EventHandler(controller.CancelClick);
        }
    }
}
