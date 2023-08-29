using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;



namespace Tour_Management_System
{
    public partial class Login : Form
    {
        string con = @"Server=localhost;Database=Todo;Trusted_Connection=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(this.con);



            SqlCommand cmd = new SqlCommand("select * from users where username=@username and password=@password", cn);
            cmd.Parameters.AddWithValue("@username", usernameText.Text);
            cmd.Parameters.AddWithValue("@password", passText.Text);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                if (dr.GetString(dr.GetOrdinal("role")) == "admin") {
                    this.Hide();
                    MessageBox.Show("Logged in Successfully", "Success");
                    DashBoard d = new DashBoard(usernameText.Text);
                    d.ShowDialog();
                } else if(dr.GetString(dr.GetOrdinal("role")) == "user")
                {
                    MessageBox.Show("Logged in successfully!", "Success");

                    this.Hide();
                    UserDashboard ud = new UserDashboard(usernameText.Text);
                    ud.ShowDialog();
                }           
            }
           
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Error");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Login";
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            this.Text = "Login";
        }
    }
}
