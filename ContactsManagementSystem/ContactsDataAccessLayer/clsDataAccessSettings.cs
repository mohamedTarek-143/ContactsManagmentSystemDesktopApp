using System;


namespace ContactsDataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static readonly string connectionString = "Server=.;Database=ContactsDB;User Id=sa;password=sa123456;TrustServerCertificate=True";
        //added ;TrustServerCertificate=True in connection string cause I am using .NET 8
    }
}
