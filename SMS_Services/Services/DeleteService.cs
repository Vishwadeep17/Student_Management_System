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
    public class DeleteService : IDeleteService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public void DeleteStudentData(int id_no)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Students WHERE SId = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id_no);
                command.ExecuteNonQuery();

                string deleteUserQuery = "DELETE FROM Users WHERE Id = @Id";
                SqlCommand deleteUserCommand = new SqlCommand(deleteUserQuery, connection);
                deleteUserCommand.Parameters.AddWithValue("@Id", id_no);
                deleteUserCommand.ExecuteNonQuery();
            }
        }
    }
}
