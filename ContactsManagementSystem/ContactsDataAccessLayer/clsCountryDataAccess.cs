using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID(int countryID, ref string countryName, ref string code, ref string phoneCode)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries where Countries.CountryID = @ID";
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", countryID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        countryName = (string)reader["CountryName"];
                        code = reader["Code"] as string?? "N/A";
                        phoneCode = reader["PhoneCode"] as string?? "N/A";


                    }
                    reader.Close();
                }catch(Exception e)
                {

                }
            }
            return isFound;
        }
        public static bool GetCountryInfoByName(string countryName, ref int countryID, ref string code, ref string phoneCode)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries where Countries.CountryName = @CountryName";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        countryID = (int)reader["CountryID"];
                        code = reader["Code"] as string ?? "N/A";
                        phoneCode = reader["PhoneCode"] as string ?? "N/A";

                    }
                    reader.Close();
                }
                catch (Exception e)
                {

                }
            }
            return isFound;
        }

        public static int AddNewCountry(string countryName, string countryCode,string phoneCode)
        {
            int givenID = -1;
            string query = @"INSERT INTO Countries(CountryName,Code,PhoneCode) values (@CountryName,@Code,@PhoneCode);
                             Select SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                command.Parameters.AddWithValue("@Code", countryCode);
                command.Parameters.AddWithValue("@PhoneCode", phoneCode);
                try
                {
                    connection.Open();
                    
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int resultID))
                    {
                        givenID = resultID;
                    }
                    
                }
                catch (Exception e)
                {

                }
            }
            return givenID;
        }
        public static bool UpdateCountryWithID(int countryID,string newName, string countryCode, string phoneCode)
        {
            int rowsAffectd = 0;
            string query = "Update Countries Set CountryName = @NewName, Code = @Code, PhoneCode = @PhoneCode where Countries.CountryID =@CountryID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NewName", newName);
                command.Parameters.AddWithValue("@CountryID", countryID);
                command.Parameters.AddWithValue("@Code", countryCode);
                command.Parameters.AddWithValue("@PhoneCode", phoneCode);
                try
                {
                    connection.Open();
                    rowsAffectd = command.ExecuteNonQuery();
                }catch(Exception e)
                {

                }
              
            }
            return rowsAffectd > 0;
        }
        public static bool DeleteCountryWithID(int ID)
        {
            int rowsAffected = 0;
            string query = "Delete from Countries where Countries.CountryID = @ID";
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
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
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Countries";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
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
        public static DataTable GetAllCountriesNames()
        {
            DataTable dt = new DataTable();
            string query = "Select Countries.CountryName from Countries";
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
        public static bool IsCountryExist(int ID)
        {
            bool found = false;
            string query = "Select Found = 1 From Countries where Countries.CountryID = @ID";
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    found = (result != null);

                }
                catch(Exception e)
                {

                }
            }
            return found;
        }
        public static bool IsCountryExist(string countryName)
        {
            bool found = false;
            string query = "Select Found = 1 From Countries where Countries.CountryName = @CountryName";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryName", countryName);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    found = (result != null);

                }
                catch (Exception e)
                {

                }
            }
            return found;
        }
    }
}
