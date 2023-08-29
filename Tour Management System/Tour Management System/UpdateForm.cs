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
    public partial class UpdateForm : Form
    {

        string con = @"Server=localhost;Database=Todo;Trusted_Connection=True;";
        int id;
        string location;
        string datee;
        int noofperson;
        string duration;
        string username;
        public UpdateForm(int id, string l, string d, int nop, string dur, string username)
        {
            this.id = id;
            this.location = l;
            this.datee = d;
            this.noofperson = nop;
            this.duration = dur;
            this.username = username;
            InitializeComponent();
        }
        public UpdateForm()
        {
            InitializeComponent();

        }
    

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.con);
            connection.Open();
            try
            {
                string query = "UPDATE tours SET location=@location, startingdate=@startingdate , duration=@duration , noofperson= @noofperson WHERE id=@id and username=@username; ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.Parameters.AddWithValue("@location", locationText.Text);
                cmd.Parameters.AddWithValue("@startingdate", startingDateText.Text);
                cmd.Parameters.AddWithValue("@duration", durationText.Text);
                cmd.Parameters.AddWithValue("@noofperson", noOfPersonsText.Text);
                cmd.Parameters.AddWithValue("@username", this.username);
                System.Console.WriteLine(this.username);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Tour updated successfully!", "Success");
                    this.Hide();
                    DashBoard d = new DashBoard(this.username);

                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tour not update", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard d = new DashBoard(this.username);
            d.ShowDialog();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.Text = "Update Tour";
            locationText.Text = this.location;
            startingDateText.Text = this.datee;
            durationText.Text = this.duration;
            noOfPersonsText.Text = Convert.ToString(this.noofperson);
        }
    }
}
