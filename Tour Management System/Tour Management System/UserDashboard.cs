using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tour_Management_System
{
    public partial class UserDashboard : Form
    {
        string con = @"Server=localhost;Database=Todo;Trusted_Connection=True;";
        string username;

        public UserDashboard()
        {
            InitializeComponent();
        }
        public UserDashboard(string u)
        {
            this.username = u;
            InitializeComponent();
        }

        private void getAllToursData()
        {
            SqlConnection connection = new SqlConnection(this.con);
            connection.Open();
            try
            {
                string query = "Select id,location,startingdate,duration,noofperson From tours";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                connection.Close();
            }



        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "User Dashboard";
            this.getAllToursData();
            labelName.Text = "Welcome ," + this.username;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.username = "";
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

    }
}
