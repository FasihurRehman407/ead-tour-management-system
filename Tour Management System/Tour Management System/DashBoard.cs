using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tour_Management_System
{
    public partial class DashBoard : Form
    {

        string con = @"Server=localhost;Database=Todo;Trusted_Connection=True;";
        string username;

        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(string u)
        {

            this.username = u;
            InitializeComponent();

        }

        private void clearFields()
        {
            locationText.Text = "";
            durationText.Text = "";
            noOfPersonsText.Text = "";
            startingDateText.Text = "";
        }

        private void getTourData()
        {
            SqlConnection connection = new SqlConnection(this.con);
            connection.Open();
            try
            {
                string query = "Select id,location,startingdate,duration,noofperson From tours where username=@username";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", this.username);
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


        private void addTourBtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(this.con);
            connection.Open();
            try
            {
                string query = "insert into tours values (@location,@startingdate,@duration,@noofperson, @username)";
                SqlCommand cmd = new SqlCommand(query, connection);

                if (locationText.Text != string.Empty && startingDateText.Text != string.Empty && durationText.Text != string.Empty && noOfPersonsText.Text != string.Empty)
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    cmd.Parameters.AddWithValue("@location", locationText.Text);
                    cmd.Parameters.AddWithValue("@startingdate", Convert.ToDateTime(startingDateText.Text, culture));
                    cmd.Parameters.AddWithValue("@duration", durationText.Text);
                    cmd.Parameters.AddWithValue("@noofperson", noOfPersonsText.Text);
                    cmd.Parameters.AddWithValue("@username", this.username);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tour created successfully!", "Success");
                    this.clearFields();
                    this.getTourData();
                }
                else
                {
                    MessageBox.Show("Fill out all the fields!", "Error");
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

        private void deleteTour(int id)
        {
            SqlConnection connection = new SqlConnection(this.con);
            connection.Open();
            try
            {
                string query = "Delete From tours where id=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Tour deleted successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Tour not deleted", "Error");
                }
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.username = "";
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdColumn"].Value);
                    this.deleteTour(id);
                    this.getTourData();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdColumn"].Value);
                string location = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["LocationColumn"].Value);
                string d = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["StartingDateColumn"].Value);
                string dur = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DurationColumn"].Value);
                int nop = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["NoOfPersonColumn"].Value);
                this.Hide();
                UpdateForm uf = new UpdateForm(id, location, d, nop, dur, this.username);
                uf.ShowDialog();

            }



        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.Text = "Dashboard";
            getTourData();
            label5.Text = "Welcome ," + this.username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdColumn"].Value);
                    this.deleteTour(id);
                    this.getTourData();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdColumn"].Value);
                string location = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["LocationColumn"].Value);
                string d = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["StartingDateColumn"].Value);
                string dur = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["DurationColumn"].Value);
                int nop = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["NoOfPersonColumn"].Value);
                this.Hide();
                UpdateForm uf = new UpdateForm(id, location, d, nop, dur, this.username);
                uf.ShowDialog();

            }
        }

      
    }
}
