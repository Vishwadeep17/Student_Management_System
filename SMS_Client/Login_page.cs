using System;
using System.Windows.Forms;

namespace SMS_Client
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                auth_ServiceRef.AuthenticationServiceClient sc1 = new auth_ServiceRef.AuthenticationServiceClient();
                (bool isValid, string role, int id) = sc1.ValidateUser(textBox1.Text, textBox2.Text);

                if (isValid)
                {
                    if (role == "admin")
                    {
                        // Navigate to admin page
                        Main_Page obj = new Main_Page();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Navigate to Student page
                        Student_page obj = new Student_page(id);
                        obj.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }
    }
}
