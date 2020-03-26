using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.db;

namespace WindowsFormsApp1.Model
{
    class queue_list_model
    {
        List<int> queue_id_list = new List<int>();
        List<String> queue_name_list = new List<String>();
        List<String> queue_description_list = new List<String>();
        List<String> in_progress_total = new List<String>();
        List<String> successfull_total = new List<String>();
        List<Boolean> isUnique_reference = new List<Boolean>();
        List<String> fail_total = new List<String>();
        List<int> total_retry = new List<int>();

        public queue_list_model()
        {
            Connector();
        }
        void Connector()
        {
            foreach (var item in DBQueries.getAllQueues())
            {
                queue_id_list.Add(item.ID);
                queue_name_list.Add(item.NAME);
                queue_description_list.Add(item.Desc);
                in_progress_total.Add(DBQueries.retrunTotalTransactionsStatus(item.ID.ToString(), STATUS.NEW).ToString());
                successfull_total.Add(DBQueries.retrunTotalTransactionsStatus(item.ID.ToString(), STATUS.SUCCESSFUL).ToString());
                isUnique_reference.Add(true);
                fail_total.Add(DBQueries.retrunTotalTransactionsStatus(item.ID.ToString(), STATUS.FAILED).ToString());
                total_retry.Add(2);
            }
        }
        public List<int> GetQueue_id_list() { return queue_id_list; }
        public List<string> GetQueue_name_list() { return queue_name_list; }
        public List<string> GetQueue_description_list() { return queue_description_list; }
        public List<string> GetIn_progress_list() { return in_progress_total; }
        public List<string> GetSuccessful_list() { return successfull_total; }
        public List<string> GetFail_total_list() { return fail_total; }
        public List<Boolean> GetIsUnique_reference_list() { return isUnique_reference; }
        public List<int> GetTotalRetry_list() { return total_retry; }
    }
}
