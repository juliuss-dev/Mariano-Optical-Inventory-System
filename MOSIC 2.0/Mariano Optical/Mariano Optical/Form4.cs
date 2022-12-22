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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");


        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            getPatient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgPatient.Rows[e.RowIndex];
                Connection.patientID = row.Cells["PatientID"].Value.ToString();
                textBox1.Text = Connection.patientID;
            }
        }


        private void getPatient()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM patient", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dvgPatient.DataSource = dt;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var frm = new Dashboard();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
