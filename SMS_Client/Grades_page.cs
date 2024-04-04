using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Client
{
    public partial class Grades_page : Form
    {
        public Grades_page()
        {
            InitializeComponent();
            DisplayGrades();
        }

        void DisplayGrades()
        {
            disp_ServiceRef.DisplayServiceClient sc3 = new disp_ServiceRef.DisplayServiceClient();
            disp_ServiceRef.Student[] studentArray = sc3.GetStudents();
            sc3.Close();
            List<disp_ServiceRef.Student> students = studentArray.ToList();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("SId", "Student ID");
            dataGridView1.Columns.Add("SName", "Name");
            dataGridView1.Columns.Add("Grades", "Grade");

            // Set the values for each cell from the list of students
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(
                    student.SId,
                    student.SName,
                    student.Grades
                );
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main_Page obj = new Main_Page();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Missing Credentials !");
            else
            {
                int studentId = Convert.ToInt32(textBox1.Text);
                string grade = comboBox1.Text;

                updt_ServiceRef.UpdateServiceClient sc5 = new updt_ServiceRef.UpdateServiceClient();
                sc5.UpdateStudentGrade(studentId, grade);
                sc5.Close();

                // Optionally, display a message to indicate the grade update
                MessageBox.Show("Grade updated successfully!");
                DisplayGrades();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Missing Credentials !");
            else
            {
                int studentId = Convert.ToInt32(textBox1.Text);

                updt_ServiceRef.UpdateServiceClient sc5 = new updt_ServiceRef.UpdateServiceClient();
                sc5.DeleteStudentGrade(studentId);
                sc5.Close();

                // Optionally, display a message to indicate the grade update
                MessageBox.Show("Grade Deleted successfully!");
                DisplayGrades();
            }
        }
    }
}
