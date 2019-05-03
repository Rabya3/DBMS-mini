using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_mini
{
    public partial class StudentPortal : Form
    {

        public StudentPortal()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";


        public int status=5;
       

        public void display()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    dataGridView1.DataSource = tbl;

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

        }




        private void StudentPortal_Load(object sender, EventArgs e)
        {
            display();

        }


        int Id = 0;
        private string fname;
        private string lname;
        private string email;
        private string contact;
        private string reg;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();



            //Clearing the textboxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from StudentAttendance where StudentId =" + dataGridView1.CurrentRow.Cells[0].Value;

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

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from StudentResult where StudentId =" + dataGridView1.CurrentRow.Cells[0].Value;

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
                    cmd.CommandText = "delete from Student where Id =" + dataGridView1.CurrentRow.Cells[0].Value;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted");
                    display();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        
       
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("All fields required");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();


                        if (comboBox1.SelectedValue == "Inactive")
                        {
                            status = 6;
                        }


                        else
                        {
                            string reguni = "SELECT RegistrationNumber FROM Student";
                            SqlCommand cmd = new SqlCommand(reguni, con);
                            var reader = cmd.ExecuteReader();
                            bool ss = true;
                            while (reader.Read())
                            {
                                if (reader[0].ToString() == textBox5.Text)
                                {
                                    ss = false;
                                }
                            }
                            if (ss == false)
                            {
                                MessageBox.Show("Roll number already exists");
                            }
                            reader.Close();
                            if (ss == true)
                            {
                                string queryaddastudent = "INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + status + "')";
                                SqlCommand comd = new SqlCommand(queryaddastudent, con);
                                comd.ExecuteNonQuery();
                                MessageBox.Show("Added and Saved");

                                //Claering the boxes
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                            }
                            display();
                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (e.ColumnIndex == 1)
            {
               

                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from StudentAttendance where StudentId='" + id + "'";
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
                        cmd.CommandText = "delete from StudentResult where StudentId='" + id+ "'";
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
                        cmd.CommandText = "delete from Student where Id='" + id + "'";
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
                        string query = "update Student set FirstName = @fn, LastName = @ln, Contact = @c, Email = @e, RegistrationNumber = @r, Status = @s where Id=@id";


                        SqlCommand cmd = new SqlCommand(query, con);
                        if (textBox1.Text != "")
                        { cmd.Parameters.AddWithValue("@fn", textBox1.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@fn", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        }

                        if (textBox2.Text != "")
                        { cmd.Parameters.AddWithValue("@ln", textBox2.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ln",dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        }
                        if (textBox3.Text != "")
                        { cmd.Parameters.AddWithValue("@c", textBox3.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@c",dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        }
                        if (textBox4.Text != "")
                        { cmd.Parameters.AddWithValue("@e", textBox4.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@e", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                        }
                        if (textBox5.Text != "")
                        { cmd.Parameters.AddWithValue("@r", textBox5.Text.ToString()); }
                        else
                        {
                            cmd.Parameters.AddWithValue("@r", dataGridView1.CurrentRow.Cells[7].Value.ToString());
                        }
                        if (comboBox1.SelectedValue == null)
                        {
                            status = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                            cmd.Parameters.AddWithValue("@s", status);
                        }

                        else if (comboBox1.SelectedValue.ToString() == "Inactive")
                        {
                            status = 6;
                            cmd.Parameters.AddWithValue("@s", status);

                        }


                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //MessageBox.Show("updated");
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
    }
}


