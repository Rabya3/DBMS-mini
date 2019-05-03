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
    public partial class Attendance : Form
    {
        string str = "Data Source=DESKTOP-H2EOT5V\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True";
        bool retVal = false;
        private int count;
        private int Reg_num;
        private int Atten_id;
        private int std_id;
        private object Status;
        private string std_reg;
        private int atten_id;
        private int atten_id1;
        private bool update_clicked;
        private bool status_selected;
        private int attend_stts;
        private int atten_status;
        public Attendance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet6.Student);
            // TODO: This line of code loads data into the 'projectBDataSet5.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet5.StudentAttendance);
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_changed);
            button11.Enabled = false;
            this.Controls.Add(button11);
            button1.Enabled = false;
            DateExist();
            if (retVal == true)
            {
                button7.Enabled = false;
                this.Controls.Add(button7);
                button1.Enabled = true;
                button10.Enabled = false;

            }
            button1.Click += new System.EventHandler(button1_clicked);

        }

        private bool DateExist()

        {



            SqlConnection con;

            SqlCommand cmSQL;

            string strSQL, s1, s2;

            s1 = "SELECT * FROM ClassAttendance ";

            s2 = "WHERE AttendanceDate = '" + dateTimePicker1.Value.ToShortDateString() + "'";

            strSQL = s1 + s2;

            con = new SqlConnection(str);

            con.Open();

            cmSQL = new SqlCommand(strSQL, con);

            SqlDataReader reader = cmSQL.ExecuteReader();

            if (!reader.HasRows)

            {

                retVal = false;

            }

            else

            {



                retVal = true;

            }

            // close the connection and query

            con.Close();



            return retVal;

        }

        private void button1_clicked(object sender, EventArgs e)
        {
            update_clicked = true;
        }

        private void dateTimePicker1_changed(object sender, EventArgs e)
        {
            DateExist();
            if (retVal == true)
            {
                button7.Enabled = false;
                this.Controls.Add(button7);
                button1.Enabled = true;
            }
            else
            {
                button7.Enabled = true;
                this.Controls.Add(button1);
                button1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query1 = "Select * from ClassAttendance where AttendanceDate='" + dateTimePicker1.Value.ToShortDateString() + "'";
                    SqlCommand command = new SqlCommand(query1, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Atten_id = Convert.ToInt32(reader["Id"]);

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
                    cmd.CommandText = "delete from StudentAttendance where AttendanceId='" + Atten_id + "'";

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
                    cmd.CommandText = "delete from ClassAttendance where Id='" + Atten_id + "'";

                    cmd.ExecuteNonQuery();
                    con.Close();


                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Error occurred");
            }


            DateExist();
            if (retVal == true)
            {
                button7.Enabled = false;
                this.Controls.Add(button7);
                button1.Enabled = true;

            }
            else
            {
                button7.Enabled = true;
                this.Controls.Add(button1);
                button1.Enabled = false;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (grid.CurrentRow.Cells[2].Value != null)
                {
                    status_selected = true;
                    MessageBox.Show(status_selected.ToString());
                }
                else
                {
                    status_selected = false;
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            button10.Enabled = true;
            button11.Enabled = false;
            this.Controls.Add(button11);
            string theDate = dateTimePicker1.Value.ToShortDateString();
            DateExist();
            if (retVal == true)
            {
                button7.Enabled = false;
                this.Controls.Add(button7);
                button1.Enabled = true;
            }
            if (retVal == false)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query = "INSERT INTO ClassAttendance(AttendanceDate) VALUES (@d)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@d", theDate);

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
                        SqlDataAdapter da = new SqlDataAdapter("select * from Student ", con);
                        DataTable tbl = new DataTable();
                        da.Fill(tbl);

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

                    try
                    {
                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from ClassAttendance where AttendanceDate='" + dateTimePicker1.Value.ToShortDateString() + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Atten_id = Convert.ToInt32(reader["Id"]);

                                }
                            }
                        }
                    }
                    catch (System.Data.SqlClient.SqlException sqlException)
                    {
                        System.Windows.Forms.MessageBox.Show(sqlException.Message);
                        MessageBox.Show("Error occurred");
                    }
                    dataGridView1.Rows[i].Cells[1].Value = Atten_id;
                }
                dataGridView1.Visible = true;
                DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["AttendanceStatus"];
                Dictionary<string, int> integers = new Dictionary<string, int>();
                integers.Add("Present", 1);
                integers.Add("Absent", 2);
                integers.Add("Leave", 3);
                integers.Add("Late", 4);
                combo.DataSource = new BindingSource(integers, null);
                combo.DisplayMember = "key";
                combo.ValueMember = "value";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            button10.Enabled = false;
            this.Controls.Add(button10);
            button11.Enabled = true;

            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Student ", con);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);

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
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from ClassAttendance where AttendanceDate='" + dateTimePicker1.Value.ToShortDateString() + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                atten_id1 = Convert.ToInt32(reader["Id"]);

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }
                dataGridView1.Rows[i].Cells[1].Value = atten_id1;
                DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["AttendanceStatus"];
                Dictionary<string, int> integers = new Dictionary<string, int>();
                integers.Add("Present", 1);
                integers.Add("Absent", 2);
                integers.Add("Leave", 3);
                integers.Add("Late", 4);
                column.DataSource = new BindingSource(integers, null);
                column.DisplayMember = "key";
                column.ValueMember = "value";

                DateExist();
                if (retVal == true)
                {
                    button7.Enabled = false;
                    this.Controls.Add(button7);
                    button1.Enabled = true;
                }
                else
                {
                    button7.Enabled = true;
                    this.Controls.Add(button1);
                    button1.Enabled = false;

                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var std_reg = dataGridView1.Rows[i].Cells[0].Value.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Student where RegistrationNumber='" + std_reg + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                std_id = Convert.ToInt32(reader["Id"]);

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }

                var atten_id = dataGridView1.Rows[i].Cells[1].Value.ToString();

                var atten_status = dataGridView1.Rows[i].Cells[2].Value.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query = "INSERT INTO StudentAttendance(AttendanceId,StudentId,AttendanceStatus) VALUES (@a_i,@s,@a_s)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@s", std_id);
                        cmd.Parameters.AddWithValue("@a_i", atten_id);
                        cmd.Parameters.AddWithValue("@a_s", atten_status);

                        cmd.ExecuteNonQuery();
                        con.Close();


                    }
                }

                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var std_reg = dataGridView1.Rows[i].Cells[0].Value.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(str))
                    {
                        con.Open();
                        string query1 = "Select * from Student where RegistrationNumber='" + std_reg + "'";
                        SqlCommand command = new SqlCommand(query1, con);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                std_id = Convert.ToInt32(reader["Id"]);

                            }
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    MessageBox.Show("Error occurred");
                }

                var atten_id = dataGridView1.Rows[i].Cells[1].Value.ToString();


                if (dataGridView1.Rows[i].Cells[2].Value != null)
                {
                    status_selected = true;

                }
                else
                {
                    status_selected = false;
                }


                if (status_selected == true)
                {
                    atten_status = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                }

                else
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(str))
                        {
                            con.Open();
                            string query1 = "Select * from StudentAttendance where studentId='" + std_id + "'";
                            SqlCommand command = new SqlCommand(query1, con);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    atten_status = Convert.ToInt32(reader["AttendanceStatus"]);

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
                        string query = "update StudentAttendance set AttendanceStatus = @a_s where StudentId = @id";
                        SqlCommand cmd = new SqlCommand(query, con);


                        cmd.Parameters.AddWithValue("@a_s", atten_status);



                        cmd.Parameters.AddWithValue("@id", std_id);

                        cmd.ExecuteNonQuery();
                        con.Close();



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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashboardSystem form =new DashboardSystem();
            form.Show();
            this.Hide();
        }
    }
}

