using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.db
{
    #region Model for outputs
    public class Output
    {
        public int ID { get; set; }
        public int QueueItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemVal { get; set; }
    }
    #endregion

    #region Model for Priority
    public class Priority
    {
        public int ID { get; set; }
        public string PrioDesc { get; set; }
    }
    #endregion

    #region Model for ProcessException
    public class ProcessException
    {
        public int ID { get; set; }
        public int QueueItemId { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public DateTime ProcessTime { get; set; }
    }
    #endregion

    #region Model for QueueItem
    public class QueueItem
    {
        public int ID { get; set; }
        public int QueueNameId { get; set; }
        public int StatusID { get; set; }
        public int PriorityID { get; set; }
        public string Reference { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreationTime { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
    #endregion

    #region Model for Queues
    public class Queues
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string Desc { get; set; }
        public int Inprogress { get; set; }
        public int Remaining { get; set; }
        public int Success { get; set; }
    }
    #endregion

    #region Model for SpecificContents
    public class SpecificContent
    {
        public int ID { get; set; }
        public int QueueItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemVal { get; set; }
    }
    #endregion

    #region Model for Status
    public class Status
    {
        public int ID { get; set; }
        public string StatusDesc { get; set; }
    }
    #endregion

    #region Unused Models
    //Model for UserLevel
    /*public class UserLevel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
    }*/

    //Model for Users
    /*class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public int UserStatusID { get; set; }
    }*/
    #endregion

    #region Model for Jobs
    public class Jobs
    {
        public int ID { get; set; }
        public string ProcessName { get; set; }
        public string DateTimeStart { get; set; }
        public string DateTimeEnd { get; set; }
        public string Status { get; set; }
        public string Value { get; set; }
    }
    #endregion

    #region Model for Logs
    public class Logs
    {
        public int ID { get; set; }
        public string JobID { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string TimeStamp { get; set; }
    }
    #endregion

    #region Model for ProcessID
    public class ProcessID
    {
        public string JobID { get; set; }
    }
    #endregion

    #region Model for Asset
    public class Asset
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Int64 ValueGroupId { get; set; }
        public int ValueTypeId { get; set; }
        public string StringValue { get; set; }
        public bool BoolValue { get; set; }
        public Int64 IntValue { get; set; }
        public string CredentialUsername { get; set; }
        public string CredentialPassword { get; set; }
        public string Description { get; set; }
    }
    #endregion

    #region Model for Schedule
    public class Schedule
    {
        public int id { get; set; }
        public string schedule_name { get; set; }
        public string robot_name { get; set; }
        public string schedule_day { get; set; }
        public string schedule_time { get; set; }
        public string schedule_added_datetime { get; set; }
        public string added_by { get; set; }
        public string should_enable { get; set; }
    }
    #endregion

    #region Model for ValueGroup
    public class ValueGroup
    {
        public int ID { get; set; }
        public string GroupDesc { get; set; }
    }
    #endregion

    #region Model for ValueType
    public class ValueType
    {
        public int ID { get; set; }
        public string Type { get; set; }
    }
    #endregion
}
