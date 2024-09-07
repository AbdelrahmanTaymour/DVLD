using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
           ref byte Gendor, ref string Address, ref string Phone, ref string Email,
           ref short NationalityCountryID, ref string ImagePath)
        {

            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM People WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                isFound = true;

                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    ThirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    ThirdName = "";
                                }

                                LastName = (string)reader["LastName"];
                                NationalNo = (string)reader["NationalNo"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];


                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }
                                else
                                {
                                    Email = "";
                                }

                                NationalityCountryID = (short)reader["NationalityCountryID"];

                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }

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

        
        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email,
         ref short NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] != DBNull.Value)
                                    ThirdName = (string)reader["ThirdName"];
                                else
                                    ThirdName = "";

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                NationalityCountryID = (short)reader["NationalityCountryID"];

                                if (reader["Email"] != System.DBNull.Value)
                                    Email = (string)reader["Email"];
                                else
                                    Email = "";


                                if (reader["ImagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = "";

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

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, 
            string NationalNo, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email,
            short NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string query = @"INSERT INTO People(FirstName, SecondName, ThirdName,LastName,NationalNo,
                                                    DateOfBirth,Gendor,Address,Phone, Email, NationalityCountryID,ImagePath)
                                        VALUES (@FirstName, @SecondName,@ThirdName, @LastName, @NationalNo,
                                               @DateOfBirth,@Gendor,@Address,@Phone, @Email,@NationalityCountryID,@ImagePath);
                                        SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (ThirdName != "" && ThirdName != null)
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        else
                            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (Email != "" && Email != null)
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            PersonID = InsertedID;
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

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, 
            string NationalNo, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email,
            short NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update  People
                                SET FirstName = @FirstName,
                                    SecondName = @SecondName,
                                    ThirdName = @ThirdName,
                                    LastName = @LastName,
                                    NationalNo = @NationalNo,
                                    DateOfBirth = @DateOfBirth,
                                    Gendor = @Gendor,
                                    Address = @Address,
                                    Phone = @Phone,
                                    Email = @Email,
                                    NationalityCountryID = @NationalityCountryID,
                                    ImagePath = @ImagePath
                              WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (ThirdName != "" && ThirdName != null)
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        else
                            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                        if (Email != "" && Email != null)
                            command.Parameters.AddWithValue("@Email", Email);
                        else
                            command.Parameters.AddWithValue("@Email", System.DBNull.Value);


                        if (ImagePath != "" && ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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
        
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Delete People 
                                    where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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
        
        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT		People.PersonID, 
			                                    People.NationalNo, 
			                                    People.FirstName,
			                                    People.SecondName,
			                                    People.ThirdName,
			                                    People.LastName,
			                                    People.DateOfBirth,
			                                    People.Gendor,
                                    CASE	WHEN People.Gendor = 0 THEN 'Male'
                            		        ELSE 'Female'
                            		        END AS GendorCaption,
                            			        People.Address,
                            			        People.Phone,
                            			        People.Email,
                            			        Countries.CountryName,
                            			        People.ImagePath
                                    From People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
                                    ORDER BY People.FirstName;";

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
    
        public static bool IsPersonExist(int PersonID)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();
                    string query = @"Select Found=1 From People Where PersonID = @PersonID;";

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isExist = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Select Found=1 From People Where NationalNo = @NationalNo;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

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


    }
}
