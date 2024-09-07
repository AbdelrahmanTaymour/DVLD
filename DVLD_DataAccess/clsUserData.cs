using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DVLD_DataAccess
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive, ref short? RoleID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Users WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                RoleID = (reader["RoleID"] != DBNull.Value) ? (short?)reader["RoleID"] : null;
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

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string Username, ref string Password, ref bool IsActive, ref short? RoleID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Users WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                RoleID = (reader["RoleID"] != DBNull.Value) ? (short?)reader["RoleID"] : null;
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

        public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int UserID, ref int PersonID, ref bool IsActive, ref short? RoleID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Users WHERE Username = @Username and Password = @Password;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                IsActive = (bool)reader["IsActive"];
                                RoleID = (reader["RoleID"] != DBNull.Value) ? (short?)reader["RoleID"] : null;
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

        public static int AddNewUser( int PersonID, string Username, string Password, bool IsActive, short? RoleID)
        {
            int UserID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Users (PersonID, Username, Password, IsActive, RoleID)
                                    VALUES (@PersonID, @Username, @Password, @IsActive, @RoleID);
                                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@RoleID", RoleID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            UserID = InsertedID;
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

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, bool IsActive, short? RoleID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Users
                                 SET PersonID = @PersonID,
                                     Username = @Username,
                                     Password = @Password,
                                     IsActive = @IsActive,
                                     RoleID = @RoleID
                                WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@UserID", UserID);
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

            return (rowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"
                            SELECT Users.UserID, Users.PersonID, 
                                   FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName,
                                   Users.Username, Roles.RoleName, Users.IsActive
                            From   Users INNER JOIN People ON Users.PersonID = People.PersonID INNER JOIN Roles ON Users.RoleID = Roles.RoleID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
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
            return dataTable;
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"DELETE FROM Users WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select Found=1 From Users Where UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isExist = reader.HasRows;
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

            return isExist;
        }

        public static bool IsUserExist(string Username)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select Found=1 From Users Where Username = @Username;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isExist = reader.HasRows;
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

            return isExist;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT Found = 1 From Users WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isExist = reader.HasRows;
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

            return isExist;
        }
    
        public static bool UpdatePassword(int UserID, string NewPassword)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update Users SET Password = @NewPassword WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", NewPassword);
                        command.Parameters.AddWithValue("@UserID", UserID);

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
