using System;
using System.Diagnostics;
using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {

        //public static string ConnectionString = @"Server=192.168.0.192;Database=DVLD;User Id=sa;Password=VeryStr0ngP@ssw0rd;";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDDbConnection"].ConnectionString;

        //public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //public static string ConnectionString = @"Server=.;Database=DVLD;User Id=sa;Password=sa123456;";

        public static void SaveToEventLog(string Message, EventLogEntryType LogType = EventLogEntryType.Error, string SourceName = "DVLD-DataAccess")
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, Message, LogType);
        }
    }
}
