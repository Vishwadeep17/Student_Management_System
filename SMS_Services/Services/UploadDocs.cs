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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UploadDocs" in both code and config file together.
    public class UploadDocs : IUploadDocs
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public IEnumerable<DocModel> get_documents(string cid)
        {
            List<DocModel> docs = new List<DocModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Documents WHERE course_id = @cid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cid", cid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DocModel doc = new DocModel
                            {
                                name = reader["name"].ToString(),
                                fileBytes = FileService.GetFile(reader["file_path"].ToString()),
                                c_id = reader["course_id"].ToString()
                            };
                            docs.Add(doc);
                        }
                    }
                }
            }
            return docs;
        }

        public void upload_documents(DocModel doc)
        {
            Console.WriteLine("Hiii");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                string query = @"INSERT INTO Documents (dname, file_path, course_id) VALUES (@dname, @file_path, @course_id)";
                SqlCommand cmd = new SqlCommand(query, connection);
                string path = FileService.UploadFile(doc.name, doc.fileBytes);
                cmd.Parameters.AddWithValue("@dname", doc.name);
                cmd.Parameters.AddWithValue("@file_path", path);
                cmd.Parameters.AddWithValue("@course_id", doc.c_id);
                Console.WriteLine(path);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


    }
}
