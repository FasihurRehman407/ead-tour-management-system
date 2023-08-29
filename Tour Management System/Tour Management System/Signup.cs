using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tour_Management_System
{
    public partial class Signup : Form
    {
        string con = @"Server=localhost;Database=Todo;Trusted_Connection=True;";

        public Signup()
        {
            InitializeComponent();
        }


        private void clearFields()
        {
            usernameText.Text = "";
            passText.Text = "";
            conPassText.Text = "";
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(this.con);


            SqlCommand cmd = new SqlCommand("insert into users values (@username,@password,@role)", cn);

            if (usernameText.Text != string.Empty && passText.Text != string.Empty && conPassText.Text != string.Empty)
            {

                if (passText.Text != conPassText.Text)
                {
                    MessageBox.Show("Password and Confirm Password are not same", "Error");

                }
                else
                {
                    cmd.Parameters.AddWithValue("@username", usernameText.Text);
                    cmd.Parameters.AddWithValue("@password", passText.Text);
                    cmd.Parameters.AddWithValue("@role", "user");

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Signed up successfully!", "Success");
                    this.Hide();
                    Login l = new Login();
                    l.ShowDialog();
                    this.clearFields();
                    cn.Close();

                }



            }
            else
            {
                MessageBox.Show("Fill out all the fields!", "Error");

            }

        }

        private void alreadyLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            this.Text = "Sign up";
        }
    }
}
