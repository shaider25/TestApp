
using System;
using System.Data.SqlClient;


namespace TestApp



{
    public class Test
    {

        public void Login(string username, string password)
        {
            string connectionString = "your_connection_string_here";
            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Invalid credentials.");
                }
            }
        }

    }
}
