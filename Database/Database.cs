using Dapper;
using SQLDatabase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1.db
{
    #region ENUM
    public enum STATUS
    {
        SUCCESSFUL, FAILED, RETRIED, NEW, INPROGRESS, DELETED, ABANDONED
    }

    public enum MODEL
    {
        QueueItem, Output, Priority, ProcessException, Queues, SpecificContent, Status
    }

    public enum AssetType
    {
        Text, Credential
    }
    #endregion

    public class Database
    {
        //Set the connection string name;
        private static string connectionName = null;

        /*============================== CREATE DATABASE =============================================*/
        //The method will create database if it is not created yet;
        #region
        public static void CreateDatabase(string name)
        {
            try
            {
                Console.WriteLine("Connection name: " + name);
                connectionName = name;
                string[] datasource = ConfigurationManager.ConnectionStrings[name].ConnectionString.Replace("  ", "").Replace(" ", "").Split(';');
                if (!File.Exists(datasource[0].Replace("DataSource=", "")))
                {
                    SQLiteConnection.CreateFile(datasource[0].Replace("DataSource=", ""));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        /*============================== CREATE TABLE ================================================*/
        #region
        public static void CreateTable(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        /*============================== DROP TABLE ==================================================*/
        #region
        public static void DropTable(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        /*============================== INSERT TO DB ================================================*/
        #region
        public static void InsetToDB(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, new DynamicParameters());
            }
        }

        //ADD NEW QUEUE
        public static void AddNewQueue(string query, Queues queue)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, queue);
            }
        }

        //Add New Asset
        public static void AddNewAsset(string query, Asset asset)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, asset);
            }
        }

        //ADD NEW JOB
        public static void AddNewJob(string query, Jobs job)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, job);
            }
        }
        #endregion

        /*============================== UPDATE DATA TO DB ===========================================*/
        #region
        public void UpdateToDB(string query, MODEL model)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, model);
            }
        }
        #endregion

        /*============================== REMOVE DATA FROM DB =========================================*/
        #region
        public void DeleteToDB(string query, MODEL model)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, model);
            }
        }
        public void DeleteAssets(string query, MODEL model)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                conn.Execute(query, model);
            }
        }
        #endregion

        /*============================== RETRIVE DATA FROM DB ========================================*/
        #region
        public static List<QueueItem> RetrieveQueueItem(string query, string id)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var ids = new { ID = id };
                var retrieved = conn.Query<QueueItem, Status, Priority, QueueItem>(query, (items, status, priority) => 
                {
                    items.Status = status.StatusDesc; items.Priority = priority.PrioDesc; return items; 
                }, ids);
                return retrieved.ToList();
            }
        }
        public static List<QueueItem> RetrieveQueueItemByStatus(string queueID, STATUS status)
        {
            string query = null;
            switch (status)
            {
                case STATUS.NEW:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 0;";
                    break;
                case STATUS.INPROGRESS:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 1;";
                    break;
                case STATUS.FAILED:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 2;";
                    break;
                case STATUS.SUCCESSFUL:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 3;";
                    break;
                case STATUS.ABANDONED:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 4;";
                    break;
                case STATUS.RETRIED:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 5;";
                    break;
                case STATUS.DELETED:
                    query = @"SELECT im.*, stat.*, prio.* FROM Item im 
                              INNER JOIN Status stat on im.StatusID = stat.ID 
                              INNER JOIN Priority prio on im.PriorityID = prio.ID 
                              WHERE im.QueueNameId = @ID AND im.StatusID = 6;";
                    break;
            }

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var ids = new { id = queueID };
                var retrieved = conn.Query<QueueItem, Status, Priority, QueueItem>(query, (items, Status, priority) => 
                {
                    items.Status = Status.StatusDesc; items.Priority = priority.PrioDesc; return items; 
                }, ids);
                return retrieved.ToList();
            }
        }
        public static List<Output> RetrieveOutput(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Output>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Priority> RetrievePriority(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Priority>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<ProcessException> RetrieveProcessException(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<ProcessException>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Logs> RetrieveLog(string query, string id)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var ids = new { ID = id };
                var retrieved = conn.Query<Logs>(query, ids);
                return retrieved.ToList();
            }
        }
        public static List<Queues> RetrieveQueues(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Queues>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<SpecificContent> RetrieveSpecificContent(string query, string ID)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var id = new { id = ID };
                var retrieved = conn.Query<SpecificContent>(query, id);
                return retrieved.ToList();
            }
        }
        public static List<Status> RetrieveStatus(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Status>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Jobs> RetrieveJobs(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Jobs>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Logs> RetrieveLogs(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Logs>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<ProcessID> RetrieveProcessID(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<ProcessID>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Asset> RetrieveAsset(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Asset>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        public static List<Schedule> RetrieveSchedule(string query)
        {
            using (IDbConnection conn = new SQLiteConnection(ConnectionString.LoadConnectionString(connectionName)))
            {
                var retrieved = conn.Query<Schedule>(query, new DynamicParameters());
                return retrieved.ToList();
            }
        }
        #endregion
    }
}
