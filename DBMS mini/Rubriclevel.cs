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
    public partial class Rubriclevel : Form
    {
        public Rubriclevel()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "" && richTextBox1.Text != "")
                {
                    con.Open();
                    string query = "INSERT INTO RubricLevel(Details, RubricId,MeasurementLevel) VALUES ('" + richTextBox1.Text + "',(select Id from Rubric where Id='" + comboBox2.SelectedValue + "'),'" + textBox1.Text + "' )";
                    SqlDataAdapter CCmd = new SqlDataAdapter(query, con);

                    CCmd.SelectCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Addition of Level Successful!");
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error");
            }
            display();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private void Rubriclevel_Load(object sender, EventArgs e)
        {
            
            display();
            Fill();
        }

        public void Fill()
        {
            using (SqlDataAdapter s = new SqlDataAdapter("SELECT Details,Id FROM Rubric", con))
            {
                DataTable tbl = new DataTable();
                s.Fill(tbl);
                comboBox2.DataSource = tbl;
                comboBox2.DisplayMember = "Details";
                comboBox2.ValueMember = "Id";
            }


        }

        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from RubricLevel where RubricId='"+comboBox2.SelectedValue+"'", con);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
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
                        cmd.CommandText = "delete from RubricLevel where Id='" + id_v + "'";

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
                        string query = "update RubricLevel set Details = @d, MeasurementLevel=@l where Id=@id";



                        SqlCommand cmd = new SqlCommand(query, con);
                        if (richTextBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@d", richTextBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@d", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        }

                        if (textBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@l", textBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@l", dataGridView1.CurrentRow.Cells[5].Value.ToString());
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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }
    }
}
