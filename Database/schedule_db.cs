using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.db
{
    class schedule_db
    {
        data_holder memory = data_holder.Instance;
        public schedule_db()
        {
            /*using (SQLiteCommand command = memory.GetDB_conn().CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS schedule (" +
                                      "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                      "schedule_name VARCHAR(50)," +
                                      "robot_name VARCHAR(50)," +
                                      "schedule_day VARCHAR(50)," +
                                      "schedule_time VARCHAR(8)," +
                                      "schedule_added_datetime VARCHAR(15)," +
                                      "added_by VARCHAR(24)," +
                                      "should_enable VARCHAR(2))";
                command.ExecuteNonQuery();
            }*/
        }
        public void AddSchedule(
            String ScheduleName, String RobotName,
            String ScheduleDay, String ScheduleTime,
            String Username)
        {
            /*string stringQuery = "INSERT INTO schedule (" +
                                "schedule_name, " +
                                "robot_name, " +
                                "schedule_day," +
                                "schedule_time," +
                                "schedule_added_datetime," +
                                "added_by," +
                                "should_enable) values ('" +
                                ScheduleName + "','" +
                                RobotName + "','" +
                                ScheduleDay + "','" +
                                ScheduleTime + "','" +
                                DateTime.Now.ToString() + "','" +
                                Username + "','" +
                                "E');"; 
            var SqliteCmd = new SQLiteCommand();
            SqliteCmd = memory.GetDB_conn().CreateCommand();
            SqliteCmd.CommandText = stringQuery;
            SqliteCmd.ExecuteNonQuery();*/
        }
        public void GetSchedule(schedule_model model)
        {
            /*using (SQLiteCommand fmd = memory.GetDB_conn().CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM schedule";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    model.getSchedule_id().Add(Convert.ToInt32(r["id"]));
                    model.getSchedule_name().Add(Convert.ToString(r["schedule_name"]));
                    model.getRobot_name().Add(Convert.ToString(r["robot_name"]));
                    model.getSchedule_day().Add(Convert.ToString(r["schedule_day"]));
                    model.getSchedule_time().Add(Convert.ToString(r["schedule_time"]));
                    model.getSchedule_status().Add(Convert.ToString(r["should_enable"]));
                }
            }*/
        }
        public void UpdateScheduleStatus(String status, int id)
        {
               /* using (SQLiteCommand command = new SQLiteCommand(memory.GetDB_conn()))
                {
                    command.CommandText =
                        "UPDATE schedule SET should_enable = :enable where id=:id";
                    command.Parameters.Add("enable", DbType.String).Value = status;
                    command.Parameters.Add("id", DbType.Int32).Value = id;
                    command.ExecuteNonQuery();
                }*/
        }
        public void DeleteSchedule(int id)
        {
            /*using (SQLiteCommand com = new SQLiteCommand(memory.GetDB_conn()))
            {
                com.CommandText = "DELETE FROM schedule WHERE id='" + id + "';";
                com.ExecuteNonQuery();
                com.Dispose();
            }*/
        }
    }
}
