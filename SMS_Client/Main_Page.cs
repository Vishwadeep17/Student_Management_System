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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            disp_ServiceRef.DisplayServiceClient sc3 = new disp_ServiceRef.DisplayServiceClient();
            disp_ServiceRef.Student[] studentArray = sc3.GetStudents();
            sc3.Close();
            List<disp_ServiceRef.Student> students = studentArray.ToList();
            dataGridView1.AutoGenerateColumns = false; // Disable auto-generation of columns

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("SId", "Student ID");
            dataGridView1.Columns.Add("SName", "Name");
            dataGridView1.Columns.Add("SAddress", "Address");
            dataGridView1.Columns.Add("SEmail", "Email");
            dataGridView1.Columns.Add("SPhone_no", "Phone Number");
            dataGridView1.Columns.Add("Sem", "Semester");
            dataGridView1.Columns.Add("Fees_paid", "Fees Paid");

            // Set the values for each cell from the list of students
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(
                    student.SId,
                    student.SName,
                    student.SAddress,
                    student.SEmail,
                    student.SPhone_no,
                    student.Sem,
                    student.Fees_paid
                );
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login_page obj = new Login_page();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Missing vital Information !");
            }
            else
            {
                add_ServiceRef.AddServiceClient sc2 = new add_ServiceRef.AddServiceClient();

                add_ServiceRef.Student student = new add_ServiceRef.Student
                {
                    SName = textBox2.Text,
                    SAddress = textBox3.Text, // Assuming textBox2 is for SAddress
                    SEmail = textBox4.Text, // Assuming textBox3 is for SEmail
                    SPhone_no = textBox5.Text, // Assuming textBox4 is for SPhone_no
                    Sem = Convert.ToInt32(comboBox1.SelectedItem), // Assuming comboBox1 is for Sem
                    Fees_paid = (string)comboBox2.SelectedItem
                };

                sc2.AddStudentData(student);

                MessageBox.Show("Student data added successfully!");
                DisplayStudents();
                sc2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Missing vital Information !");
            }
            else
            {
                updt_ServiceRef.UpdateServiceClient sc4 = new updt_ServiceRef.UpdateServiceClient();

                updt_ServiceRef.Student student = new updt_ServiceRef.Student
                {
                    SId = Convert.ToInt32(textBox1.Text),
                    SName = textBox2.Text,
                    SAddress = textBox3.Text, // Assuming textBox2 is for SAddress
                    SEmail = textBox4.Text, // Assuming textBox3 is for SEmail
                    SPhone_no = textBox5.Text, // Assuming textBox4 is for SPhone_no
                    Sem = Convert.ToInt32(comboBox1.SelectedItem), // Assuming comboBox1 is for Sem
                    Fees_paid = (string)comboBox2.SelectedItem
                };

                sc4.UpdateStudentData(student);

                MessageBox.Show("Student data Updated successfully!");
                sc4.Close();

                DisplayStudents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Missing Vital information !");
            else
            {
                del_ServiceRef.DeleteServiceClient sc5 = new del_ServiceRef.DeleteServiceClient();
                sc5.DeleteStudentData(Convert.ToInt32(textBox1.Text));
                sc5.Close();
                MessageBox.Show("Student data Deleted successfully!");
                button4_Click(sender, e);
                DisplayStudents();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Courses_page obj = new Courses_page();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Grades_page obj = new Grades_page();
            obj.Show();
            this.Hide();
        }
    }
}
