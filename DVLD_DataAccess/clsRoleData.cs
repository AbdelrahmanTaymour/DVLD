using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsRoleData
    {
        public static DataTable GetAllRoles()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Roles;";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
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
        public static bool GetRoleByID(short? RoleID, ref string RoleName)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT * FROM Roles WHERE RoleID = @RoleID;";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                RoleName = (string)reader["RoleName"];
                            }
                            else
                                isFound = false;
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

            }

            return isFound;
        }
        public static bool GetRoleByRoleName(string RoleName, ref short? RoleID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT * FROM Roles WHERE RoleName = @RoleName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleName", RoleName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                RoleID = (reader["RoleID"] != DBNull.Value) ? (short?)reader["RoleID"] : null;
                            }
                            else
                                isFound = false;
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

            }

            return isFound;
        }
        public static short? AddNewRole(string RoleName)
        {
            short? RoleID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Roles(RoleName)
                                    VALUES (@RoleName);
                                    SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleName", RoleName);

                        object result = command.ExecuteScalar();

                        if(result != null && short.TryParse(result.ToString(), out short InsertedID))
                        {
                            RoleID = InsertedID;
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

            return RoleID;
        }

        public static bool UpdateRole(short? RoleID, string RoleName)
        {
            short rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Roles
                                 SET  RoleName = @RoleName
                                WHERE RoleID = @RoleID;";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);
                        command.Parameters.AddWithValue("@RoleName", RoleName);

                        rowsAffected = (short)command.ExecuteNonQuery();
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

            return rowsAffected > 0;
        }

        public static bool DeleteRole(short? RoleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE Roles WHERE RoleID = @RoleID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleID", RoleID);

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


            return rowsAffected > 0;
        }


    }
}
