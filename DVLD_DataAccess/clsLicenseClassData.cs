using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsLicenseClassData
    {
        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName,  ref string Description,
            ref byte MinAge, ref byte ValidtityLength, ref float ClassFees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                ClassName = (string)reader["ClassName"];
                                Description = (string)reader["ClassDescription"];
                                MinAge = (byte)reader["MinimumAllowedAge"];
                                ValidtityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToSingle(reader["ClassFees"]);
                            }
                            else
                            {
                                isFound = false;
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

        public static bool GetLicenseClassInfoByClassName(string ClassName, ref int LicenseClassID, ref string Description,
            ref byte MinAge, ref byte ValidtityLength, ref float ClassFees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;
                                LicenseClassID = (int)reader["LicenseClassID"];
                                Description = (string)reader["ClassDescription"];
                                MinAge = (byte)reader["MinimumAllowedAge"];
                                ValidtityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = Convert.ToSingle(reader["ClassFees"]);
                            }
                            else
                            {
                                isFound = false;
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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select * FROM LicenseClasses;";

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

        public static int AddNewLicenseClass(string ClassName, string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            int LicenseClassID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Insert Into LicenseClasses 
                   (
                    ClassName,ClassDescription,MinimumAllowedAge, 
                    DefaultValidityLength,ClassFees)
                                    Values ( 
                    @ClassName,@ClassDescription,@MinimumAllowedAge, 
                    @DefaultValidityLength,@ClassFees)
                                    where LicenseClassID = @LicenseClassID;
                                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LicenseClassID = insertedID;
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

            return LicenseClassID;
        }

        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName,
            string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {

            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"Update  LicenseClasses  
                                    set ClassName = @ClassName,
                                        ClassDescription = @ClassDescription,
                                        MinimumAllowedAge = @MinimumAllowedAge,
                                        DefaultValidityLength = @DefaultValidityLength,
                                        ClassFees = @ClassFees
                                        where LicenseClassID = @LicenseClassID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

    }
}
