using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.db;

namespace WindowsFormsApp1.Controller
{
    class schedule_model
    {
        data_holder memory = data_holder.Instance;
        List<int> schedule_id = new List<int>();
        List<String> robot_name = new List<String>();
        List<String> schedule_name = new List<String>();
        List<String> schedule_day = new List<String>();
        List<String> schedule_time = new List<String>();
        List<String> schedule_status = new List<String>();

        int[] test_data_schedule_id = { 1, 2, 3, 4 };
        String[] test_data_robot_name = { 
                "thisisaruntest",
                "Register robot tester",
                "Input data robot tester",
                "Output data robot tester"
        };
        String[] test_data_schedule_day = {
                "MON,TUE,WED,THU,FRI,SAT,SUN",
                "MON,TUE,WED,THU,FRI,SAT,SUN",
                "MON,TUE,WED,THU,FRI,SAT,SUN",
                "MON,TUE,WED,THU,FRI,SAT,SUN"
        };
        String[] test_data_schedule_time = {
                "15:38",
                "14:00",
                "15:17",
                "15:18"
        };
        String[] test_data_schedule_status = { "E", "D", "E", "E" };

        public schedule_model()
        {
            new schedule_db().GetSchedule(this);
        }
        void add_test_data()
        {
            for(int count=0; count < test_data_robot_name.Count(); count++)
            {
                schedule_id.Add(test_data_schedule_id[count]);
                robot_name.Add(test_data_robot_name[count]);
                schedule_day.Add(test_data_schedule_day[count]);
                schedule_time.Add(test_data_schedule_time[count]);
                schedule_status.Add(test_data_schedule_status[count]);
            }
        }
        public List<int> getSchedule_id() { return schedule_id; }
        public List<String> getRobot_name() { return robot_name; }
        public List<String> getSchedule_day() { return schedule_day; }
        public List<String> getSchedule_time() { return schedule_time; }
        public List<String> getSchedule_status() { return schedule_status; }
        public List<String> getSchedule_name() { return schedule_name; }
    }
}
