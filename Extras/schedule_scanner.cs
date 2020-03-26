using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class schedule_scanner
    {
        List<String> robot_name;
        List<String> schedule_day;
        List<String> schedule_time;
        List<String> schedule_status;

        public List<String> ShouldRun = new List<String>();

        public schedule_scanner(
            List<String> robot_name,
            List<String> schedule_day,
            List<String> schedule_time,
            List<String> schedule_status)
        {
            this.robot_name = robot_name;
            this.schedule_day = schedule_day;
            this.schedule_time = schedule_time;
            this.schedule_status = schedule_status;
        }
        public List<String> scheduleFinder()
        {
            for(int count = 0; count < robot_name.Count; count++)
            {
                if (schedule_time[count].Equals(DateTime.Now.ToString("HH:mm")))
                {
                    if (schedule_day[count].Contains(DateTime.Now.ToString("ddd").ToUpper()) &&
                        schedule_status[count].Equals("E"))
                    {
                        ShouldRun.Add(robot_name[count] + "$" + schedule_time[count]);
                    }
                }
            }
            return ShouldRun;
        }
    }
}
