using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class splashscreen : Form
    {
        private System.Windows.Forms.Timer timer1;
        private int counter = 0;
        data_holder memory = data_holder.Instance;
        public splashscreen()
        {
            InitializeComponent();
            Console.WriteLine("Environment.UserName: " + Environment.UserName);            
            Self_Init();
        }
        void Self_Init()
        {
            main_panel.BackgroundImage= System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\loading_screen.png");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
        }
        private void tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 3)
            {
                timer1.Stop();
                new Form2().Visible = true;
                this.Visible = false;
            } else {
                String message_status = "Loading";
                foreach (var times in Enumerable.Range(0, counter))
                {
                    message_status = message_status + ". ";
                }
                status.Text = message_status;
            }
        }
    }
}
