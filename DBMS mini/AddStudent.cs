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
    public partial class AddStudent : Form
    {
 
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source = MAXIMUS\\SQLEXPRESS; Initial Catalog = ProjectB; Integrated Security = True";
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    string query = "INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" +textBox3.Text + "','" + textBox4.Text.ToString() + "','" + textBox5.ToString() + "','" +Convert.ToInt32( textBox6.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }//Your insert code here
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

        }
    }
}
