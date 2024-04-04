using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UpdateService : IUpdateService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public void UpdateStudentData(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Students 
                                 SET SName = @SName, 
                                     SAddress = @SAddress, 
                                     SEmail = @SEmail, 
                                     SPhone_no = @SPhone_no, 
                                     Sem = @Sem, 
                                     Fees_paid = @Fees_paid
                                 WHERE SId = @SId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SId", student.SId);
                command.Parameters.AddWithValue("@SName", student.SName);
                command.Parameters.AddWithValue("@SAddress", student.SAddress);
                command.Parameters.AddWithValue("@SEmail", student.SEmail);
                command.Parameters.AddWithValue("@SPhone_no", student.SPhone_no);
                command.Parameters.AddWithValue("@Sem", student.Sem);
                command.Parameters.AddWithValue("@Fees_paid", student.Fees_paid);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStudentGrade(int studentId, string grade)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Students SET Grades = @Grades WHERE SId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Grades", grade);
                command.Parameters.AddWithValue("@StudentId", studentId);                
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudentGrade(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Students SET Grades = NULL WHERE SId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.ExecuteNonQuery();
            }
        }
    }
}
