using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public (bool isValid, string role, int studentId) ValidateUser(string username, string password)
        {
            bool isValid = false;
            string role = "";
            int studentId = -1; // Default value if not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*), Role, Id FROM Users WHERE Username = @Username AND Password = @Password GROUP BY Role, Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isValid = true;
                    role = reader["Role"].ToString();
                    studentId = Convert.ToInt32(reader["Id"]);
                }
            }

            return (isValid, role, studentId);
        }
    }
}