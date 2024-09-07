using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsApplicationTypeData
    {
        public static bool GetApplicationTypeByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref float ApplicationFees)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                                ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);
                            }
                            else
                                isFound = false;

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
        
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM ApplicationTypes;";

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

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  ApplicationTypes  
                                set ApplicationTypeTitle = @ApplicationTypeTitle,
                                    ApplicationFees = @ApplicationFees
                                    where ApplicationTypeID = @ApplicationTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                        command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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

        public static int AddNewApplicationType( string Title,  float Fees)
        {
            int ApplicationTypeID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"INSERT INTO ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
                                VALUES (@ApplicationTypeTitle, @ApplicationFees);
                                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
                        command.Parameters.AddWithValue("@ApplicationFees", Fees);

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            ApplicationTypeID = InsertedID;
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

            return ApplicationTypeID;
        }
    }
}
