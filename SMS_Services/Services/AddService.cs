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
    public class AddService : IAddService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public void AddStudentData(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Students (SName, SAddress, SEmail, SPhone_no, Sem, Fees_paid)
                        OUTPUT INSERTED.SID
                        VALUES (@SName, @SAddress, @SEmail, @SPhone_no, @Sem, @Fees_paid)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SName", student.SName);
                command.Parameters.AddWithValue("@SAddress", student.SAddress);
                command.Parameters.AddWithValue("@SEmail", student.SEmail);
                command.Parameters.AddWithValue("@SPhone_no", student.SPhone_no);
                command.Parameters.AddWithValue("@Sem", student.Sem);
                command.Parameters.AddWithValue("@Fees_paid", student.Fees_paid);

                // Fetch the inserted student ID
                int studentId = (int)command.ExecuteScalar();

                // Insert into Users table
                string insertUserQuery = @"INSERT INTO Users (Id, Username, Password, Role)
                                    VALUES (@Id, @Username, @Password, @Role)";
                SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection);
                insertUserCommand.Parameters.AddWithValue("@Id", studentId);
                insertUserCommand.Parameters.AddWithValue("@Username", student.SName);
                insertUserCommand.Parameters.AddWithValue("@Password", "12345");
                insertUserCommand.Parameters.AddWithValue("@Role", "student");
                try
                {
                    insertUserCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // You can handle the error here, such as logging it or displaying an error message to the user
                }
            }
        }

    }
}
