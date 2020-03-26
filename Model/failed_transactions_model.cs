using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class failed_transactions_model
    {
        List<String> transaction_name = new List<String>();

        String[] transaction_name_test_data = { "ACCOUNT-REQUEST01022020.xlsx", "ACCOUNT-REQUEST01122020.xlsx" };

        public failed_transactions_model()
        {
            create_test_data();
        }
        void create_test_data()
        {
            for (int count = 0; count < transaction_name_test_data.Length; count++)
            {
                transaction_name.Add(transaction_name_test_data[count]);
            }
        }
        public List<String> GetTransactionName() { return transaction_name; }
    }
}
