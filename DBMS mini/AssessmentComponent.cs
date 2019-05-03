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
    public partial class AssessmentComponent : Form
    {
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        private int rubric_id;
        private int assessment_id;
        private bool date_changed1;
        private bool date_changed2;

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.

            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new System.EventHandler(dateTimePicker2_ValueChanged);
            display();
            Fill();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed2 = true;        }

        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from AssessmentComponent where AssessmentId='"+comboBox1.SelectedValue+"'", con);
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

        public void Fill()
        {
            using (SqlDataAdapter s = new SqlDataAdapter("SELECT Id,Details FROM Rubric", con))
            {
                DataTable tbl = new DataTable();
                s.Fill(tbl);
                comboBox2.DataSource = tbl;
                comboBox2.DisplayMember = "Details";
                comboBox2.ValueMember = "Id";
            }

            using (SqlDataAdapter s = new SqlDataAdapter("SELECT Id,Title FROM Assessment", con))
            {
                DataTable tbl = new DataTable();
                s.Fill(tbl);
                comboBox1.DataSource = tbl;
                comboBox1.DisplayMember = "Title";
                comboBox1.ValueMember = "Id";
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {

                    con.Open();
                    string query = "INSERT INTO AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES ('" + textBox1.Text.ToString() + "',(select Id from Rubric where Id='" + comboBox2.SelectedValue + "'),'"+textBox3.Text+"','" +dateTimePicker1.Value + "','"+dateTimePicker2.Value+"','" + comboBox1.SelectedValue + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added and Saved");
                    display();
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        cmd.CommandText = "delete from StudentResult where AssessmentComponentId='" + id_v + "'";

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
                        cmd.CommandText = "delete from AssessmentComponent where Id='" + id_v + "'";

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
                rubric_id = Convert.ToInt32(comboBox2.SelectedValue);
                assessment_id = Convert.ToInt32(comboBox1.SelectedValue);
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        var id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        string query = "update AssessmentComponent set Name=@n,RubricId=@r,TotalMarks=@m,DateCreated=@c,DateUpdated=@u,AssessmentId=@i  where Id=@id";



                        SqlCommand cmd = new SqlCommand(query, con);
                        if (textBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@n", textBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@n", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        }
                        if (comboBox2.SelectedItem != null)
                        {

                            cmd.Parameters.AddWithValue("@r", rubric_id);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@r", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        }
                        if (textBox3.Text != "")
                        { cmd.Parameters.AddWithValue("@m", textBox3.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@m", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        }
                        if (date_changed1 == true)
                        { cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@c", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        }
                        if (date_changed2 == true)
                        { cmd.Parameters.AddWithValue("@u", dateTimePicker2.Value); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@u", dataGridView1.CurrentRow.Cells[7].Value.ToString());
                        }



                        cmd.Parameters.AddWithValue("@i", assessment_id);
                        cmd.Parameters.AddWithValue("@id", id);
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
