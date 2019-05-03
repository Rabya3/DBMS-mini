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
    public partial class DashboardSystem : Form
    {
        public DashboardSystem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }

        private void DashboardSystem_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CloForm s = new CloForm();
            s.Show();
            this.Hide();
        }
        int Id = 0;
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rubric s = new Rubric(Id);
            s.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloForm s = new CloForm();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rubric s = new Rubric(Id);
            s.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAssesment ass = new AddAssesment();
            ass.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rubriclevel lvl = new Rubriclevel();
            lvl.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AssessmentComponent ac = new AssessmentComponent();
            ac.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentEvalutions se = new StudentEvalutions();
            se.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Attendance form = new Attendance();
            form.Show();
            this.Hide();
        }
    }
}
