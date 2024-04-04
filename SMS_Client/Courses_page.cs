using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMS_Client
{
    public partial class Courses_page : Form
    {
        public Courses_page()
        {
            InitializeComponent();
            DisplayCourse();
        }
        private void DisplayCourse()
        {
            mngCourse_ServiceRef.ManageCourseClient sc = new mngCourse_ServiceRef.ManageCourseClient();
            mngCourse_ServiceRef.Course[] courseArray = sc.GetCourses();
            sc.Close();

            List<mngCourse_ServiceRef.Course> courses = new List<mngCourse_ServiceRef.Course>(courseArray);

            dataGridView1.AutoGenerateColumns = false; // Disable auto-generation of columns

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("CourseId", "Course ID");
            dataGridView1.Columns.Add("CourseName", "Course Name");

            // Add courses to DataGridView manually
            foreach (var course in courses)
            {
                dataGridView1.Rows.Add(course.CourseId, course.CourseName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Missing Course Name!");
            }
            else
            {
                mngCourse_ServiceRef.ManageCourseClient sc6 = new mngCourse_ServiceRef.ManageCourseClient();

                mngCourse_ServiceRef.Course course = new mngCourse_ServiceRef.Course
                {
                    CourseName = Convert.ToString(textBox1.Text),
                };

                sc6.AddCourse(course);

                MessageBox.Show("Course added successfully!");
                DisplayCourse();
                sc6.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") MessageBox.Show("Missing Information !");
            else
            {
                int courseId = Convert.ToInt32(textBox2.Text);
                string newCourseName = textBox1.Text;

                mngCourse_ServiceRef.ManageCourseClient sc = new mngCourse_ServiceRef.ManageCourseClient();
                mngCourse_ServiceRef.Course course = new mngCourse_ServiceRef.Course
                {
                    CourseId = courseId,
                    CourseName = newCourseName
                };
                sc.UpdateCourse(course);
                sc.Close();

                MessageBox.Show("Course updated successfully!");
                DisplayCourse();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") MessageBox.Show("Missing Information !");
            else
            {
                int courseId = Convert.ToInt32(textBox2.Text);

                mngCourse_ServiceRef.ManageCourseClient sc = new mngCourse_ServiceRef.ManageCourseClient();
                sc.DeleteCourse(courseId);
                sc.Close();

                MessageBox.Show("Course deleted successfully!");
                DisplayCourse();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Page obj = new Main_Page();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Upload_Page obj = new Upload_Page();
            obj.Show();
            this.Hide();
        }
    }
}
