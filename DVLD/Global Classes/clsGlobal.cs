using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace DVLD.Globle_Classes
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser;

        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        private const string UsernameValueName = "Username";
        private const string PasswordValueName = "Password";

        public static bool SaveLoginCredentials(string Username, string Password)
        {
            try
            {
                Registry.SetValue(RegistryKeyPath, UsernameValueName, Username, RegistryValueKind.String);
                Registry.SetValue(RegistryKeyPath, PasswordValueName, Password, RegistryValueKind.String);
                return true;

            }
            catch (Exception ex)
            {
                clsGlobal.SaveToEventLog($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public static bool GetLoginCredentials(out string Username, out string Password)
        {
            Username = null; Password = null;
            try
            {
                Username = Registry.GetValue(RegistryKeyPath, UsernameValueName, null) as string;
                Password = Registry.GetValue(RegistryKeyPath, PasswordValueName, null) as string;
                return (Username != null || Password != null);

            }
            catch (Exception ex)
            {
                clsGlobal.SaveToEventLog($"Unexpected Error: {ex.Message}");
                return false;
            }
        }

        public static void SaveToEventLog(string Message, EventLogEntryType LogType = EventLogEntryType.Error, string SourceName = "DVLD_App")
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, Message, LogType);
        }



        //Must be secure later...

        public static string Key = "1234567890123456";


    }
}

