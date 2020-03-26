using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Extras
{
    class GetQueueItemStatusType
    {
        public String GetType(int id)
        {
            String type = "";
            switch (id)
            {
                case 0:
                    type = "New";
                    break;
                case 1:
                    type = "In Progress";
                    break;
                case 2:
                    type = "Failed";
                    break;
                case 3:
                    type = "Successful";
                    break;
                case 4:
                    type = "Abandoned";
                    break;
                case 5:
                    type = "Retried";
                    break;
                case 6:
                    type = "Deleted";
                    break;
            }
            return type;
        }
    }
}
