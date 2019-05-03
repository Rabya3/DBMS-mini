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
    public partial class CloForm : Form
    {
        public CloForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert INTO Clo(Name,DateCreated,DateUpdated) VALUES('" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy")  + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')";
            SqlCommand cmd3 = new SqlCommand(query, con);
            cmd3.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("CLO Added");
            textBox1.Text = "";
        }
       
        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Clo", con);
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

        
        private bool date_changed2;
        private bool date_changed1;

        

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void CloForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);
            display();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date_changed2 = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var id_v = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                try
                {


                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Rubric where CloId = '" + id_v + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var rubric_id = Convert.ToInt32(reader["Id"]);

                                try
                                {
                                    using (SqlConnection conn = new SqlConnection(str))
                                    {


                                        conn.Open();
                                        SqlCommand cmd = conn.CreateCommand();
                                        cmd.CommandType = CommandType.Text;

                                        cmd.CommandText = "delete from AssessmentComponent where RubricId = '" + rubric_id + "'";
                                        cmd.ExecuteNonQuery();
                                        conn.Close();


                                    }
                                }
                                catch (System.Data.SqlClient.SqlException sqlException)
                                {
                                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                                    MessageBox.Show("Error occurred");
                                }

                            }
                        }
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
                        string query1 = "Select * from Rubric where CloId = '" + id_v + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                var rubric_id = Convert.ToInt32(reader["Id"]);

                                try
                                {
                                    using (SqlConnection conn = new SqlConnection(str))
                                    {

                                        conn.Open();
                                        SqlCommand cmd = conn.CreateCommand();
                                        cmd.CommandType = CommandType.Text;

                                        cmd.CommandText = "delete from RubricLevel where RubricId = '" + rubric_id + "'";
                                        cmd.ExecuteNonQuery();
                                        conn.Close();


                                    }
                                }
                                catch (System.Data.SqlClient.SqlException sqlException)
                                {
                                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                                    MessageBox.Show("Error occurred");
                                }
                            }
                        }
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

                        cmd.CommandText = "delete from Rubric where CloId='" + id_v + "'";
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
                        cmd.CommandText = "delete from Clo where Id='" + id_v + "' ";

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

                MessageBox.Show("Deleted");
            }

            if (e.ColumnIndex == 1)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        var id_v = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        string query = "update Clo set Name = @n,DateCreated=@dc, DateUpdated=@du  where Id=@id";


                        SqlCommand cmd = new SqlCommand(query, con);
                        if (textBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@n", textBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@n", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        }



                        if (date_changed1 == true)
                        { cmd.Parameters.AddWithValue("@dc", dateTimePicker1.Value); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@dc", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        }
                        if (date_changed2 == true)
                        { cmd.Parameters.AddWithValue("@du", dateTimePicker2.Value); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@du", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        }



                        cmd.Parameters.AddWithValue("@id", id_v);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updated");
                        display();
                    }

                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }

                if (e.ColumnIndex == 0)
                {

                    Rubric r = new Rubric(Convert.ToInt32( dataGridView1.CurrentRow.Cells[3].Value));
                    r.Show();
                    this.Hide();
                }
            }

        }
    }
}
