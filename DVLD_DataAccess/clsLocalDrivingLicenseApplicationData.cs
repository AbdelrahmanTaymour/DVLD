using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID,
            ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return isFound;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID,
            ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
                            }
                            else
                                return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return isFound;
        }

        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM LocalDrivingLicenseApplications_View
                                        order by ApplicationDate Desc;";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return dt;
        }
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO LocalDrivingLicenseApplications ( 
                                ApplicationID,LicenseClassID)
                                 VALUES (@ApplicationID,@LicenseClassID);
                                 SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("LicenseClassID", LicenseClassID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            LocalDrivingLicenseApplicationID = InsertedID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,
           int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE LocalDrivingLicenseApplications
                                SET ApplicationID = @ApplicationID,
                                    LicenseClassID = @LicenseClassID
                               WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE LocalDrivingLicenseApplications 
                                                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return (rowsAffected > 0);
        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT top 1 TestResult 
                               FROM LocalDrivingLicenseApplications 
                         INNER JOIN TestAppointments
                                 ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                         INNER JOIN Tests 
                                 ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                              WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                          	    AND (TestAppointments.TestTypeID = @TestTypeID)
                           ORDER BY TestAppointments.TestAppointmentID DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        object result = command.ExecuteScalar();

                        if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                        {
                            Result = returnedResult;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return Result;
        }
        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT top 1 Found=1 
                               FROM LocalDrivingLicenseApplications 
                         INNER JOIN TestAppointments
                                 ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                         INNER JOIN Tests 
                                 ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                              WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                          	    AND (TestAppointments.TestTypeID = @TestTypeID)
                           ORDER BY TestAppointments.TestAppointmentID DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        object result = command.ExecuteScalar();

                        if(result != null)
                        {
                            isFound = true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return isFound;
        }
        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte TotalTrialsPerTest = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT TotalTrialsPerTest = COUNT(TestID)
                               FROM LocalDrivingLicenseApplications 
                         INNER JOIN TestAppointments
                                 ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                         INNER JOIN Tests 
                                 ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                              WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                          	    AND (TestAppointments.TestTypeID = @TestTypeID);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        object result = command.ExecuteScalar();

                        if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                        {
                            TotalTrialsPerTest = Trials;
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return TotalTrialsPerTest;
        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT Found=1 
                                       FROM TestAppointments 
                                 INNER JOIN LocalDrivingLicenseApplications
                                         ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                                      WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                                        AND (TestAppointments.TestTypeID = @TestTypeID) 
                                        AND (IsLocked =0)
                                   ORDER BY TestAppointments.TestAppointmentID DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            Result = true;
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                clsDataAccessSettings.SaveToEventLog($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.SaveToEventLog($"Unexpected Error: {ex.Message}");
            }

            return Result;
        }

    }
}
