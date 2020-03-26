using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class schedule_scanner_model
    {
        List<String> robot_name = new List<String>();
        List<String> schedule_day = new List<String>();
        List<String> schedule_time = new List<String>();

        String[] test_data_robot_name = { "My login robot tester", "My logout robot tester" };
        String[] test_data_schedule_day = { "WED", "WED" };
        String[] test_data_schedule_time = { "20:13", DateTime.Now.ToString("HH:mm") };
        void add_test_data()
        {
            for(int count = 0; count < test_data_robot_name.Count(); count++)
            {
                robot_name.Add(test_data_robot_name[count]);
                schedule_day.Add(test_data_schedule_day[count]);
                schedule_time.Add(test_data_schedule_time[count]);
            }
        }
        public schedule_scanner_model()
        {
            add_test_data();
            //DB CALL SHOULD BE HERE
        }
        public List<String> getRobot_name() { return robot_name; }
        public List<String> getSchedule_day() { return schedule_day; }
        public List<String> getSchedule_time() { return schedule_time; }
    }
}
