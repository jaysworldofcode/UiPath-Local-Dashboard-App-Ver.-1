using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Model
{
    class robot_model
    {
        data_holder memory = new data_holder();
        List<String> robot_id = new List<String>();
        List<String> robot_name = new List<String>();
        List<String> robot_description = new List<String>();
        List<String> robot_current_version = new List<String>();
        List<String> robot_published_date = new List<String>();
        public robot_model()
        {
            for (int count=0;count<Directory.GetDirectories(memory.GetPackage_Path()).Length;count++)
            {
                is_path_robot checker = new is_path_robot(Directory.GetDirectories(memory.GetPackage_Path())[count]);
                if (checker.isPathRobot())
                {
                    robot_id.Add(count.ToString());
                    robot_name.Add(new DirectoryInfo(Directory.GetDirectories(memory.GetPackage_Path())[count]).Name);
                    robot_description.Add("No description");
                    robot_current_version.Add(new DirectoryInfo(
                        Directory.GetDirectories(
                            Directory.GetDirectories(memory.GetPackage_Path())[count]
                        )[0]).Name);
                    robot_published_date.Add(
                        Directory.GetLastWriteTime(Directory.GetDirectories(
                            Directory.GetDirectories(memory.GetPackage_Path())[count]
                        )[0]).ToString());
                }
            }
        }
        public List<string> GetRobot_ID() { return robot_id; }
        public List<string> GetRobot_Name() { return robot_name; }
        public List<string> GetRobot_Description() { return robot_description; }
        public List<string> GetRobot_CurrentVersion() { return robot_current_version; }
        public List<string> GetRobot_published_date() { return robot_published_date; }
    }
}
