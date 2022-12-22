using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Initial_UI_Mariano_Optical
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");


        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Connection.patientID))
            {

            }
            else
            {
                tbPatientID.Text = Connection.patientID;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Patient", con);
                string query = "Select * From patient where patientid = '" + tbPatientID.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                tbLName.Text = dt.Rows[0]["lname"].ToString();
                tbFName.Text = dt.Rows[0]["fname"].ToString();
                tbMName.Text = dt.Rows[0]["mname"].ToString();
                tbAddress.Text = dt.Rows[0]["address"].ToString();
                tbGender.Text = dt.Rows[0]["gender"].ToString();
                tbBday.Text = dt.Rows[0]["birthdate"].ToString();

                
                
                cmd = new SqlCommand("Select * From checkup", con);
                query = "Select * From checkup where patientid = '" + Connection.patientID + "'";
                sda = new SqlDataAdapter(query, con);
                dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                tbVisualAcuity.Text = dt.Rows[0]["visualAcuity"].ToString();
                else
                {

                }
                

                con.Close(); 
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new New_Patient();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new ShowDetails();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Search();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }
    }
}
