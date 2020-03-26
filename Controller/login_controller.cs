using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class login_controller
    {
        Form1 main;
        public login_controller(Form1 main)
        {
            this.main = main;
        }
        public void LoginPress(object sender, EventArgs e)
        {
            Form2 tb = new Form2();
            tb.Show();
            main.Visible = false;
        }
    }
}
