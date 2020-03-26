using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.db;

namespace WindowsFormsApp1.Controller
{
    class run_action_bar_controller
    {
        data_holder memory = data_holder.Instance;
        run_action_bar main;
        private Timer timer1;
        Form2 task_bar;
        public run_action_bar_controller(run_action_bar main, Form2 task_bar)
        {
            this.main = main;
            this.task_bar = task_bar;

            timer1 = new Timer();
            timer1.Interval = 200;
            timer1.Tick += show_tick;
            timer1.Enabled = true;
        }
        Boolean doneSetWindowState = false;
        int minuteChecker = 61;
        private void show_tick(object sender, EventArgs e)
        {
            /*if (!(minuteChecker == int.Parse(DateTime.Now.ToString("mm"))))
            {
                List<String> GetRobotNameShouldRunList = new schedule_scanner(
                                                        memory.GetScheduleModel().getRobot_name(),
                                                        memory.GetScheduleModel().getSchedule_day(),
                                                        memory.GetScheduleModel().getSchedule_time(),
                                                        memory.GetScheduleModel().getSchedule_status()
                                                    ).scheduleFinder();
                if (!(GetRobotNameShouldRunList.Count()==0))
                        new jobs_db().NewJob(
                         GetRobotNameShouldRunList[0].Split(Char.Parse("$"))[0],
                         DateTime.Now.ToString("yyyyMMddHHmmss"),
                         DateTime.Now.ToString(),
                         "N/A",
                         "P"
                         //memory.GetDB_conn()
                         );
                minuteChecker = int.Parse(DateTime.Now.ToString("mm"));
            }
             if (Process.GetProcessesByName("UiPath.Executor").Length > 0){
                main.Visible = true;
                task_bar.Enabled = false;
                task_bar.WindowState = FormWindowState.Minimized;
                doneSetWindowState = false;
                memory.JobID = "";
            } else {
                main.Visible = false;
                task_bar.Enabled = true;
                if (!doneSetWindowState)
                {
                    task_bar.WindowState = FormWindowState.Normal;
                    doneSetWindowState = true;
                }
                if (String.IsNullOrEmpty(memory.JobID) ||
                    String.IsNullOrWhiteSpace(memory.JobID))
                {
                    new RunTracker();
                } else {
                    new jobs_db().UpdateStatus(
                        "S", 
                        memory.JobID,
                        memory.GetDB_conn()
                    );
                }
            }*/
        }
        public void StopPress(object sender, EventArgs e)
        {
            new Stop();
        }
        public void RestartPress(object sender, EventArgs e)
        {
            new Stop();
            System.Threading.Thread.Sleep(2000);
            new Run(memory.current_robot_run);
        }
    }
}
