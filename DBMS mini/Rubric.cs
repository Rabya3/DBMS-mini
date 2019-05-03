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
    public partial class Rubric : Form
    {

        public Rubric(int r)
        {
            InitializeComponent();


        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

        private void Rubric_Load(object sender, EventArgs e)
        {
            Fill();
            display();
            Fill();


        }

        SqlCommand cmd;
        public void Fill()
        {
            using (SqlDataAdapter s = new SqlDataAdapter("SELECT Id,Name FROM Clo", con))
            {
                DataTable tbl = new DataTable();
                s.Fill(tbl);
                comboBox2.DataSource = tbl;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "" && richTextBox1.Text != "")
                {
                    con.Open();
                    string query = "INSERT INTO Rubric(Details, CloId) VALUES ('" + richTextBox1.Text + "',(select Id from Clo where Id='" + comboBox2.SelectedValue + "'))";
                    SqlDataAdapter CCmd = new SqlDataAdapter(query, con);

                    CCmd.SelectCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Addition of Rubric Successful!");
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error");
            }
            display();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }
        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Rubric where CloId='" + comboBox2.SelectedValue + "'", con);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
        int Id = 0;
        private int clo_id;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());






        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Rubric where Id =" + dataGridView1.Rows[Id].Cells[0].Value;

            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.Rows.RemoveAt(Id);
            MessageBox.Show("Deleted");
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


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
                        cmd.CommandText = "delete from RubricLevel where RubricId='" + id_v + "'";

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
                        cmd.CommandText = "delete from AssessmentComponent where RubricId='" + id_v + "'";

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
                        cmd.CommandText = "delete from Rubric where Id='" + id_v + "'";

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
                        string query1 = "Select * from Clo where Name = '" + comboBox2.SelectedItem + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clo_id = Convert.ToInt32(reader["Id"]);
                                break;
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
                        string query = "update Rubric set Details = @d, CloId=@c where Id=@id";



                        SqlCommand cmd = new SqlCommand(query, con);
                        if (richTextBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@d", richTextBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@d", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        }
                        
                            cmd.Parameters.AddWithValue("@c", comboBox2.SelectedValue);
                       





                        cmd.Parameters.AddWithValue("@id", id_v);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        display();
                        MessageBox.Show("Updated");
                    }

                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            display();
        }
    }
}

