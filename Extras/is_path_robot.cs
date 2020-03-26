using System;
using System.IO;

namespace WindowsFormsApp1.Extras
{
    class is_path_robot
    {
        Boolean isRobot;
        String robot_version;
        String robot_path;
        public is_path_robot(String path)
        {
            if (Directory.GetDirectories(path).Length == 0)
            {
                isRobot = false;
            } else {
                String[] files_list = Directory.GetFiles(Directory.GetDirectories(path)[0]);
                if (String.Join("//",files_list).Contains("nuget.props"))
                {
                    isRobot = true;
                } else
                {
                    isRobot = false;
                }
            }
        }
        public Boolean isPathRobot()
        {
            return isRobot;
        }
    }
}
