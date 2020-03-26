using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Extras
{
    class Stop
    {
        public Stop()
        {
            string processName = "UiPath.Executor";

            foreach (Process process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }
    }
}
