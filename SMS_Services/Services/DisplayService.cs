using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace SMS_Services.Services
{
    public class DisplayService : IDisplayService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                SId = (int)reader["SId"],
                                SName = reader["SName"].ToString(),
                                SAddress = reader["SAddress"].ToString(),
                                SEmail = reader["SEmail"].ToString(),
                                SPhone_no = reader["SPhone_no"].ToString(),
                                Sem = (int)reader["Sem"],
                                Fees_paid = reader["Fees_paid"].ToString(),
                                Grades = reader["Grades"].ToString()
                            };
                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }
        public Student GetStudentInfo(int studentId)
        {
            Student student = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students WHERE SId = @StudentId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student
                            {
                                SId = (int)reader["SId"],
                                SName = reader["SName"].ToString(),
                                SAddress = reader["SAddress"].ToString(),
                                SEmail = reader["SEmail"].ToString(),
                                SPhone_no = reader["SPhone_no"].ToString(),
                                Sem = (int)reader["Sem"],
                                Fees_paid = reader["Fees_paid"].ToString(),
                                Grades = reader["Grades"].ToString()
                            };
                        }
                    }
                }
            }

            return student;
        }
    }
}
