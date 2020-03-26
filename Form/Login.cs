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
using WindowsFormsApp1.Test_Files;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        login_controller controller;
        data_holder memory = data_holder.Instance;
        public Form1()
        {
            //Connect db
            InitializeComponent();
            Self_init();
        }
        void Self_init()
        {
            controller = new login_controller(this);
            BT_Login.Click += new EventHandler(controller.LoginPress);
        }
    }
}