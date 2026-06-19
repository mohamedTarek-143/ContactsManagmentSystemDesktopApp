using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ContactsDataAccessLayer
{
    public static class clsContactDataAccess // all methods in Data Acess layer is static
    {
        // public int ContactID { get; set; }
       

        public static bool GetContactInfoByID(int ID,ref string firstName, ref string lastName,
            ref string email, ref string phone, ref string address, ref DateTime dateOfBirth,
            ref int countryID, ref string imagePath)
        {
            bool isFound = false;
            string query = "Select * from Contacts Where Contacts.ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString)) 
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ContactID", ID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound     = true;
                            firstName   = reader["FirstName"] as string ?? "N/A";
                            lastName    = reader["LastName"] as string ?? "N/A";
                            email       = reader["Email"] as string ?? "N/A";
                            phone       = reader["Phone"] as string ?? "N/A";
                            address     = reader["Address"] as string ?? "N/A";
                            dateOfBirth = (DateTime)reader["DateOfBirth"];
                            countryID   = (int)reader["CountryID"];
                            imagePath   = reader["ImagePath"] as string ?? "N/A";
                        }
                    }
                    
                    
                }
                catch(Exception e)
                {
                    //Console.WriteLine(e.Message);
                    isFound = false;
                    
                }
            }

            return isFound;
        }

        public static int AddNewContact(string firstName, string lastName,
             string email, string phone, string address, DateTime dateOfBirth,
            int countryID, string imagePath)
        {
            int contactID = -1;
            string query = @"Insert into Contacts (FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)
                             Values (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @CountryID, @ImagePath);
                             Select Cast( SCOPE_IDENTITY() as INT);";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@CountryID", countryID);
                if(imagePath != null && imagePath != "")
                {
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                }
                else
                {
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                }

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if(result != null && result != DBNull.Value)
                    {
                        contactID = (int)result;
                        
                    }

                }catch(Exception ex)
                {

                }
               
                
            }

            return contactID;
        }

        public static bool UpdateContactWithID(int ID, string firstName, string lastName,
             string email, string phone, string address, DateTime dateOfBirth,
            int countryID, string imagePath)
        {
            int rowsAffected = 0;
            string query = @"UPDATE Contacts Set FirstName = @FirstName, LastName = @LastName,
                             Email = @Email, Phone = @Phone, Address = @Address, DateOfBirth =@DateOfBirth,
                             CountryID = @CountryID, ImagePath = @ImagePath
                             Where Contacts.ContactID = @ID";
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@CountryID", countryID);
                if (imagePath != null && imagePath != "")
                {
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                }
                else
                {
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                }

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch(Exception ex)
                {
                    
                }
            }
            return rowsAffected > 0;
        }
        public static bool DeleteContact(int ID)
        {
            int rowsAffected = 0;
            string query = "DELETE FROM Contacts Where ContactID = @ID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    
                }catch(Exception e)
                {

                }
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllContacts()
        {
            string query = "SELECT * FROM Contacts";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                try{
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                   
                    dt.Load(reader);
                    
                    reader.Close();

                }catch(Exception e)
                {

                }
                
            }
            return dt;
        }
        public static DataTable GetAllDetails()
        {
            string query = "Select ContactID, FirstName, LastName, Email,Phone,Address, DateOfBirth, CountryID ,ImagePath,CountryName, Code from AllDetailsView";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    reader.Close();

                }
                catch (Exception e)
                {

                }

            }
            return dt;
        }
        
        public static bool IsContactExists(int ID)
        {
            bool found = false;
            string query = "Select Found = 1 from Contacts where Contacts.ContactID = @ID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    found = (result != null);
                    
                }catch(Exception e)
                {

                }
            }
            return found;
        }

    }

}
