using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Extras
{
    class RunTracker
    {
        data_holder memory = data_holder.Instance;
        public RunTracker()
        {
            /*jobs_model model = new jobs_model();
            if (String.Join("//", model.getStatus()).Contains("P"))
            {
                int index = model.getStatus().IndexOf("P");
                new Run(model.getRobotName()[index]);
                memory.JobID = model.getJobID()[index];
                new jobs_db().UpdateCurrentJobDetails(
                        model.getRobotName()[index],
                        model.getJobID()[index],
                        memory.GetDB_conn()
                );
            }*/
        }
    }
}
