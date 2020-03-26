using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    class Run
    {
        public Run(String robot)
        {
            Console.WriteLine("Start " + DateTime.Now.ToString());
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    if (File.Exists("C:\\Program Files (x86)\\UiPath\\Studio\\UiRobot.exe"))
                    {
                        sw.WriteLine("cd /d C:\\Program Files (x86)\\UiPath\\Studio");
                        sw.WriteLine("UiRobot.exe execute --process " + robot);
                    } else if (File.Exists("C:\\Program Files (x86)\\UiPath\\Studio\\UiRobot.exe"))
                    {
                        sw.WriteLine("cd /d C:\\Program Files (x86)\\UiPath\\Studio");
                        sw.WriteLine("UiRobot.exe execute --process " + robot);
                    } else
                    {
                        MessageBox.Show("UiRobot.exe not installed....");
                    }
                }
            }
            while (true)
            {
                try
                {
                    var time = p.StartTime;
                    break;
                }
                catch (Exception) { }
            }
            Console.WriteLine("Stop " + DateTime.Now.ToString());
            p.Dispose();
        }
    }
}
