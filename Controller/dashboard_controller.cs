using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1.Controller
{
    class dashboard_controller
    {
        Dashboard_Panel main;
        public dashboard_controller(Dashboard_Panel main)
        {
            this.main = main;
        }
        public void queue_data_change(object sender, EventArgs e)
        {
            main.SetPieChartData();
            main.SetGaugeStatus();
        }
    }
}
