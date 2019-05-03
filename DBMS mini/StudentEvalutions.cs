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
    public partial class StudentEvalutions : Form
    {
        public StudentEvalutions()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True");
        string str = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        private int rubric_id;
        private int Student_id;
        private int Assessment_component_id;
        private int Measurement_id;
        private int Assessment_id;
        private int Assessment_comp_id;
        private bool index_changed1;
        private bool index_changed2;
        private bool index_changed3;

        private bool index_changed4;
        private int Assessment_id1;
        private bool date_changed1;
        private int std_id;
        private string std_reg;

        public void display()
        {

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from StudentResult", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    //dataGridView1.DataSource = tbl;
                    dataGridView1.DataSource = tbl;
                    con.Close();

                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                std_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Student where Id='" + std_id + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //std_fname = reader["FirstName"].ToString();
                                //std_lname = reader["LastName"].ToString();
                                std_reg = reader["RegistrationNumber"].ToString();
                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                dataGridView1.Rows[i].Cells[2].Value = std_reg;
                //std_fname + " " + std_lname + " \\ " + 
            }
        }
        

        public void Calculations()
        {
            int totalmarks = 0;
            string sql = "Select TotalMarks, from AssessmentComponent where Name='" + comboBox2.Text + "')";



            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    totalmarks = (int)cmd.ExecuteScalar();
                    MessageBox.Show(Convert.ToString(totalmarks));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentEvalutions_Load(object sender, EventArgs e)

        {
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            // TODO: This line of code loads data into the 'projectBDataSet1.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet1.StudentResult);
            Assessment_component_id = 0;
            Measurement_id = 0;
            Student_id = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Student";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["RegistrationNumber"]);

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
                    string query1 = "Select * from Assessment";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["Title"]);

                        }
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }

            comboBox3.Click += new System.EventHandler(comboBox3_clicked);
            comboBox4.Click += new System.EventHandler(comboBox4_clicked);

            comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_changed);
            comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_changed);
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_changed);
            comboBox4.SelectedIndexChanged += new System.EventHandler(comboBox4_changed);
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;

            Student_id = 0;
            Assessment_component_id = 0;
            Measurement_id = 0;
            display();

            var id_a = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where Id='" + id_a + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rubric_id = Convert.ToInt32(reader["RubricId"]);

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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_changed1 = true;
        }
        private void comboBox3_clicked(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from Assessment where Title = '" + comboBox2.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Assessment_id = Convert.ToInt32(reader["Id"]);
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
            comboBox3.Items.Clear();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where AssessmentId='" + Assessment_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox3.Items.Add(reader["Name"]);

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
        private void comboBox4_clicked(object sender, EventArgs e)
        {
            Assessment_comp_id = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from AssessmentComponent where Name = '" + comboBox3.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Assessment_comp_id = Convert.ToInt32(reader["RubricId"]);
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
            if (index_changed3 != true)
            {
                Assessment_comp_id = 0;
            }
            comboBox4.Items.Clear();
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from RubricLevel where RubricId='" + Assessment_comp_id + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox4.Items.Add(reader["MeasurementLevel"]);
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
        private void comboBox4_changed(object sender, EventArgs e)
        {
            index_changed4 = true;
        }

        private void comboBox1_changed(object sender, EventArgs e)
        {
            index_changed1 = true;

        }

        private void comboBox2_changed(object sender, EventArgs e)
        {
            index_changed2 = true;
        }

        private void comboBox3_changed(object sender, EventArgs e)
        {
            index_changed3 = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculations();
            Assessment_component_id = 0;

            comboBox3.Items.Clear();
            if (index_changed2 == true)
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Assessment where Title = '" + comboBox2.SelectedItem + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Assessment_id1 = Convert.ToInt32(reader["Id"]);
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
                if (index_changed3 == true)
                {
                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from AssessmentComponent where Name = '" + comboBox3.Text + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Assessment_component_id = Convert.ToInt32(reader["Id"]);
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
                    MessageBox.Show(Assessment_component_id.ToString());
                }


                Measurement_id = 0;
                if (index_changed4 == true)
                {
                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from RubricLevel where MeasurementLevel = '" + comboBox4.Text + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Measurement_id = Convert.ToInt32(reader["Id"]);
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
                }

                Student_id = 0;
                if (index_changed1 == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from Student where RegistrationNumber = '" + comboBox1.SelectedItem + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Student_id = Convert.ToInt32(reader["Id"]);
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
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query = "INSERT INTO StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) VALUES (@s,@a,@r,@d)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@s", Student_id);
                        cmd.Parameters.AddWithValue("@a", Assessment_component_id);
                        cmd.Parameters.AddWithValue("@r", Measurement_id);
                        cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value);

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



                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox1.SelectedItem = null;



                Assessment_component_id = 0;
                Measurement_id = 0;
                Student_id = 0;
                Assessment_comp_id = 0;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem s = new DashboardSystem();
            s.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                var id_v = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                var id_aa = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                if (e.ColumnIndex == 1)
                {
                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "delete from StudentResult where StudentId='" + id_v + "' and AssessmentComponentId='" + id_aa + "' ";

                            cmd.ExecuteNonQuery();
                            con.Close();
                            SqlDataAdapter da = new SqlDataAdapter("select * from StudentResult", con);
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


                if (e.ColumnIndex == 0)
                {

                    try
                    {

                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from RubricLevel where MeasurementLevel = '" + comboBox4.SelectedItem + "' and RubricId= '" + rubric_id + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Measurement_id = Convert.ToInt32(reader["Id"]);
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

                            var id_ss = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                            var id_ass = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                            string query = "update StudentResult set RubricMeasurementId=@m,EvaluationDate=@d  where StudentId=@id and AssessmentComponentId=@a";



                            SqlCommand cmd = new SqlCommand(query, con);






                            if (comboBox4.SelectedItem != null)
                            {
                                cmd.Parameters.AddWithValue("@m", Measurement_id);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@m", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                            }
                            if (date_changed1 == true)
                            { cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value); }
                            else
                            {
                                cmd.Parameters.AddWithValue("@d", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                            }


                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id_ss));
                            cmd.Parameters.AddWithValue("@a", Convert.ToInt32(id_ass));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    } 
