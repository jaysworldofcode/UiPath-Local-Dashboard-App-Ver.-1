using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.db
{
    class assets_db
    {
        data_holder memory = data_holder.Instance;
        public assets_db()
        {

        }
        public void GetAssets(SQLiteConnection sqlite_conn)
        {
            /*using (SQLiteCommand fmd = sqlite_conn.CreateCommand())
            {
                fmd.CommandText = @"SELECT * FROM Asset";
                fmd.CommandType = CommandType.Text;
                SQLiteDataReader r = fmd.ExecuteReader();
                while (r.Read())
                {
                    model.GetAssetID().Add(Convert.ToInt16(r["ID"]));
                    model.GetAssetName().Add(Convert.ToString(r["Name"]));
                    model.GetAssetType().Add(Convert.ToString(r["ValueTypeId"]));
                    if (String.IsNullOrEmpty(Convert.ToString(r["StringValue"])) ||
                        String.IsNullOrWhiteSpace(Convert.ToString(r["StringValue"])))
                    {
                        model.GetAssetValue().Add(Convert.ToString(r["CredentialUsername"]));
                    } else {
                        model.GetAssetValue().Add(Convert.ToString(r["StringValue"]));
                    }
                    model.GetAssetPasswordValue().Add(Convert.ToString(r["CredentialPassword"]));
                    model.GetAssetDescription().Add(Convert.ToString(r["Description"]));
                }
            }*/
        }
        public void DeleteAssets(int id)
        {
            /*using (SQLiteCommand com = new SQLiteCommand(sqlite_conn))
            {
                com.CommandText = "DELETE FROM Asset WHERE id='" + id + "';";
                com.ExecuteNonQuery();
                com.Dispose();
            }*/
        }
        public void AddAssets(
            String asset_name, String value_type,
            String set_value, String password, 
            String description, String username)
        {
            /*String encrypted_password = "";
            if (value_type.Equals("4"))
            {
                encrypted_password = new Encrypt().EncryptData(
                    password,
                    username
                    );
            }
            string stringQuery = "INSERT INTO Asset (" +
                                "Name, " +
                                "ValueTypeId, " +
                                "StringValue," +
                                "CredentialUsername," +
                                "CredentialPassword," +
                                "Description) values ('" +
                                asset_name + "'," +
                                value_type + ",'" +
                                set_value + "','" +
                                username + "','" +
                                encrypted_password + "','" +
                                description + "');";

            var SqliteCmd = new SQLiteCommand();
            SqliteCmd = memory.GetDB_conn().CreateCommand();
            SqliteCmd.CommandText = stringQuery;
            SqliteCmd.ExecuteNonQuery();*/
        }
    }
}
