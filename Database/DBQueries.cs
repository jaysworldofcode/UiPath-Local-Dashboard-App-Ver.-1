using SQLDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.db
{
    public class DBQueries
    {
        #region Jobs, Logs
        //Get and return a list of Jobs
        public static List<Jobs> GetJobs()
        {
            return Database.RetrieveJobs(@"SELECT ID as Value, ProcessName, DateTimeStart, DateTimeEnd, Status FROM Jobs");
        }

        //Add new Jobs to DB
        public static void AddNewJob(Jobs job)
        {

        }

        //Return a list of job logs
        public static List<Logs> loadLog(String job_id)
        {
            return Database.RetrieveLog(@"SELECT * FROM Logs WHERE JobID = @ID", job_id);
        }
        #endregion

        #region Queue, QueueItems, Specific Contents
        //Add new Queue
        public void AddNewQueue(Queues queue)
        {
            Database.AddNewQueue(@"INSERT INTO QueueName (Name, Desc) values (@Name, @Desc)", queue);
        }

        //Return a list of Queues
        public static List<Queues> getAllQueues()
        {
            return Database.RetrieveQueues("select * from QueueName");
        }

        //Return a list of Transactions
        public static List<QueueItem> QueueItems(string id)
        {
            return Database.RetrieveQueueItem(@"SELECT im.*, stat.*, prio.* FROM Item im 
                                                INNER JOIN Status stat on im.StatusID = stat.ID 
                                                INNER JOIN Priority prio on im.PriorityID = prio.ID 
                                                WHERE QueueNameId = @ID ORDER By CreationTime Desc;", id);
        }

        //Return a list of SpecificContents of a scpecific transaction
        public List<SpecificContent> loadSpecificContent(string id)
        {
            return Database.RetrieveSpecificContent(@"SELECT * FROM SpecificContent WHERE QueueItemId = @ID;", id);
        }
        #endregion

        #region Returns a Number Transactions base on status
        public static int retrunTotalTransactionsStatus(string ID, STATUS status)
        {
            int count = 0;
            switch (status)
            {
                case STATUS.NEW:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.SUCCESSFUL:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.FAILED:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.DELETED:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.INPROGRESS:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.RETRIED:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
                case STATUS.ABANDONED:
                    count = Database.RetrieveQueueItemByStatus(ID, status).Count();
                    break;
            }
            return count;
        }
        #endregion

        #region Assets
        public static List<Asset> getAllAssets()
        {
            return Database.RetrieveAsset("SELECT * from Asset");
        }
        public static void AddNewAsset(Asset asset, AssetType assettype)
        {
            switch (assettype)
            {
                case AssetType.Text:
                    Database.AddNewAsset(@"INSERT into Asset (Name, ValueTypeId, StringValue, Description) 
                                            VALUES (@Name, @ValueTypeId, @StringValue, @Description)", asset);
                    break;
                case AssetType.Credential:
                    Database.AddNewAsset(@"INSERT into Asset (Name, ValueTypeId, CredentialUsername, CredentialPassword, Description) 
                                            VALUES (@Name, @ValueTypeId, @CredentialUsername, @CredentialPassword, @Description)", asset);
                    break;
            }
        }
        #endregion

        #region Schedule
        public static List<Schedule> getAllSchedule()
        {
            return Database.RetrieveSchedule("SELECT * from schedule");
        }
        #endregion

        #region Create Table if Not exists
        public void CreateDBAndTable()
        {
            Console.WriteLine("Checking if should create Database and Tables..");
            
            //Create QueueName Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS QueueName (
                                    ID   INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Name STRING  UNIQUE,
                                    Desc STRING)");

            //Create Item Table if not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Item (
                                    ID           INTEGER  PRIMARY KEY AUTOINCREMENT,
                                    QueueNameId  INTEGER  REFERENCES QueueName (ID),
                                    StatusID     INTEGER  REFERENCES Status (ID),
                                    PriorityID   INTEGER  REFERENCES Priority (ID),
                                    Reference    STRING,
                                    StartTime    DATETIME,
                                    EndTime      DATETIME,
                                    CreationTime DATETIME)");

            //Create Status Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Status (
                                    ID          INTEGER PRIMARY KEY,
                                    StatusDesc STRING  UNIQUE)");

            //Create Priority Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Priority (
                                    ID       Integer PRIMARY KEY,
                                    PrioDesc String  UNIQUE)");

            //Create SpecificContent Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS SpecificContent (
                                    ID          Integer PRIMARY KEY AUTOINCREMENT,
                                    QueueItemId Integer REFERENCES Item (ID),
                                    ItemName    String,
                                    ItemVal     String)");

            //Create ProcessExceptions Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS ProcessExceptions (
                                    ID          Integer  PRIMARY KEY AUTOINCREMENT,
                                    QueueItemId Integer  REFERENCES Item (ID),
                                    Type        String,
                                    Reason String,
                                    ProcessTime DATETIME)");

            //Create Output Table if Not Exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Output (
                                    ID          INTEGER PRIMARY KEY AUTOINCREMENT,
                                    QueueItemId INTEGER REFERENCES Item (ID),
                                    ItemName    STRING,
                                    ItemVal     STRING)");

            //Create Asset table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Asset (
                                    ID                 INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Name               STRING  UNIQUE,
                                    ValueGroupId       BIGINT  REFERENCES ValueGroup (ID),
                                    ValueTypeId        INT     REFERENCES ValueType (ID),
                                    StringValue        STRING,
                                    BoolValue          BOOLEAN,
                                    IntValue           BIGINT,
                                    CredentialUsername STRING,
                                    CredentialPassword STRING,
                                    Description        STRING)");

            //Create Jobs Table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Jobs (
                                    ID INTEGER  PRIMARY KEY,
                                    ProcessName   STRING,
                                    DateTimeStart DATETIME,
                                    DateTimeEnd   DATETIME,
                                    Status STRING)");

            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS CurrentJobDetails (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    JobID VARCHAR(50),
                                    ProcessName VARCHAR(50))");

            //Create Logs Table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS Logs (
                                    ID          INTEGER  PRIMARY KEY AUTOINCREMENT,
                                    JobID       STRING   REFERENCES Jobs (ID),
                                    Level       STRING   CHECK (Level IN ('Info', 'Fatal', 'Error', 'Warn', 'Trace') ),
                                    Description STRING,
                                    TimeStamp   DATETIME)");

            //Create ProcessID Table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS ProcessID (
                                   JobID STRING PRIMARY KEY)");

            //Create ValueGroup Table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS ValueGroup (
                                   ID        INTEGER PRIMARY KEY AUTOINCREMENT,
                                   GroupDesc STRING  UNIQUE)");

            //Create ValueType Table if not exists
            Database.CreateTable(@"CREATE TABLE IF NOT EXISTS ValueType (
                                   ID   INTEGER PRIMARY KEY AUTOINCREMENT,
                                   Type STRING  UNIQUE)");

            /*======================= INSERT DEFAULT VALUES ==================================*/
            //This will insert default values on each table that has its default values
            #region
            //Insert Default values of Status Table
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (0,'New')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (1,'InProgress')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (2,'Failed')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (3,'Successful')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (4,'Abandoned')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (5,'Retried')");
            Database.InsetToDB("INSERT OR IGNORE INTO Status ('ID',StatusDesc) VALUES (6,'Deleted')");

            //Insert Default value of Priority Table
            Database.InsetToDB("INSERT OR IGNORE INTO Priority ('ID',PrioDesc) VALUES (0,'Low')");
            Database.InsetToDB("INSERT OR IGNORE INTO Priority ('ID',PrioDesc) VALUES (1,'Normal')");
            Database.InsetToDB("INSERT OR IGNORE INTO Priority ('ID',PrioDesc) VALUES (2,'High')");

            //Insert Default value of ValueGroup Table
            Database.InsetToDB("INSERT OR IGNORE INTO ValueGroup (GroupDesc) VALUES('Global')");

            //Insert Default value of ValueType Table
            Database.InsetToDB("INSERT OR IGNORE INTO ValueType (Type) VALUES('Text')");
            Database.InsetToDB("INSERT OR IGNORE INTO ValueType (Type) VALUES('Bool')");
            Database.InsetToDB("INSERT OR IGNORE INTO ValueType (Type) VALUES('Integer')");
            Database.InsetToDB("INSERT OR IGNORE INTO ValueType (Type) VALUES('Credential')");
            #endregion

        }
        #endregion
    }
}
