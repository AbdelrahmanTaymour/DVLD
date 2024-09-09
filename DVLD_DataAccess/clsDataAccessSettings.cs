using System;
using System.Diagnostics;
using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDDbConnection"].ConnectionString;

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
