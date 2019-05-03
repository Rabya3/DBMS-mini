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

namespace DBMS_mini
{
    public partial class AddAssesment : Form
    {
        public AddAssesment()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        private bool date_changed1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAssesment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);
            display();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;
        }

        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Assessment", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    dataGridView1.DataSource = tbl;

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }// TODO: This line of code loads data into the 'projectBDataSet.Student' table. 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {

                    con.Open();
                    string query = "INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage) VALUES ('" + textBox1.Text.ToString() + "','" + dateTimePicker2.Value + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added and Saved");
                    display();

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id_v = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (e.ColumnIndex == 1)
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete  from AssessmentComponent where AssessmentId='" + id_v + "'";

                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Assessment where Id='" + id_v + "'";

                        cmd.ExecuteNonQuery();
                        con.Close();
                        display();

                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }


            }
            if (e.ColumnIndex == 0)
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query = "update Assessment set Title = @t,DateCreated=@c,TotalMarks=@m,TotalWeightage=@w  where Id=@id";

                        SqlCommand cmd = new SqlCommand(query, con);
                        if (textBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@t", textBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@t", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        }



                        if (date_changed1 == true)
                        { cmd.Parameters.AddWithValue("@c", dateTimePicker2.Value); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@c", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        }
                        if (textBox3.Text != "")
                        { cmd.Parameters.AddWithValue("@m", textBox3.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@m", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        }
                        if (textBox4.Text != "")
                        { cmd.Parameters.AddWithValue("@w", textBox4.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@w", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        }



                        cmd.Parameters.AddWithValue("@id", id_v);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("updated");
                        display();
                    }

                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem from = new DashboardSystem();
            from.Show();
            this.Hide();
        }
    }
}
