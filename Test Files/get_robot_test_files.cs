using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Test_Files
{
    class get_robot_test_files
    {
        data_holder memory = data_holder.Instance;
        robot_model model = new robot_model();
        public get_robot_test_files()
        {
            /* is_path_robot checker = new is_path_robot("C:\\Users\\RPA-06\\.nuget\\packages\\tester.run");
            MessageBox.Show(checker.isPathRobot().ToString()); */
        }
    }
}
