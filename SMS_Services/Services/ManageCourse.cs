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
    public class ManageCourse : IManageCourse
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public void AddCourse(Course course)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Courses (CourseName) VALUES (@CourseName)";
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@CourseId", course.CourseId);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // You can handle the error here, such as logging it or displaying an error message to the user
                }
            }
        }

        public void UpdateCourse(Course course)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Courses SET CourseName = @CourseName WHERE CourseId = @CourseId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseId", course.CourseId);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // You can handle the error here, such as logging it or displaying an error message to the user
                }
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM Courses WHERE CourseId = @CourseId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseId", courseId);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // You can handle the error here, such as logging it or displaying an error message to the user
                }
            }
        }


        public Course[] GetCourses()
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Courses";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = Convert.ToString(reader["CourseName"])
                    };

                    courses.Add(course);
                }

                reader.Close();
            }

            return courses.ToArray();
        }

        public void RemoveCourseForStudent(int studentId, int courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM StudentCourses WHERE StudentId = @StudentId AND CourseId = @CourseId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@CourseId", courseId);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // You can handle the error here, such as logging it or displaying an error message to the user
                }
            }
        }


        public Course[] GetCoursesForStudent(int studentId)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT c.* FROM Courses c INNER JOIN StudentCourses sc ON c.CourseId = sc.CourseId WHERE sc.StudentId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = Convert.ToString(reader["CourseName"])
                    };

                    courses.Add(course);
                }

                reader.Close();
            }

            return courses.ToArray();
        }

        public void AddCourseForStudent(int studentId, int courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO StudentCourses (StudentId, CourseId) VALUES (@StudentId, @CourseId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@CourseId", courseId);

                try
                {
                    command.ExecuteNonQuery();
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
