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
    public partial class ShowDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");
        private int checkupID = 0;

        public ShowDetails()
        {
            InitializeComponent();
        }

        private void ShowDetails_Load(object sender, EventArgs e)
        {
            int checkupID=0;
            checkupID = GenerateRandomNo();
            tbCheckupNo.Text = checkupID.ToString();

            tbPatientID.Text = Connection.patientID;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Patient", con);
            string query = "Select * From patient where patientid = '" + tbPatientID.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            tbLName.Text = dt.Rows[0]["lname"].ToString();
            tbFName.Text = dt.Rows[0]["fname"].ToString();
            tbMName.Text = dt.Rows[0]["mname"].ToString();
            tbAddress.Text = dt.Rows[0]["address"].ToString();
            tbOccupation.Text = dt.Rows[0]["occupation"].ToString();
            tbAge.Text = dt.Rows[0]["age"].ToString();
            tbGeneder.Text = dt.Rows[0]["gender"].ToString();
            tbHeight.Text = dt.Rows[0]["height"].ToString();
            tbWeight.Text = dt.Rows[0]["weight"].ToString();
            tbBP.Text = dt.Rows[0]["bp"].ToString();
            tbBday.Text = dt.Rows[0]["birthdate"].ToString();
            tbContactNumber.Text = dt.Rows[0]["cnum"].ToString();
            tbEmail.Text = dt.Rows[0]["email"].ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit basic info

            tbHeight.ReadOnly = false;
            tbWeight.ReadOnly = false;
            tbBP.ReadOnly = false;
            tbAddress.ReadOnly = false;
            tbOccupation.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbContactNumber.ReadOnly = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //save button
        private void button3_Click(object sender, EventArgs e)
        {
            


            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select * From checkup", con);
            string query = "Select * From checkup where patientid = '" + tbPatientID.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                //UPDATE 
                cmd = new SqlCommand("UPDATE checkup SET visualAcuity = @visualAcuity, cEER = @cEER, prescriptionDetails = @prescriptionDetails" +
                    "frameDetails = @frameDetails", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@patientID", tbPatientID.Text);
                cmd.Parameters.AddWithValue("@visualAcuity", visualAcuity.Text);
                cmd.Parameters.AddWithValue("@cEER", cEER.Text);
                cmd.Parameters.AddWithValue("@prescriptionDetails", prescriptionDetails.Text);
                cmd.Parameters.AddWithValue("@frameDetails", frameDetails.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Info Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //save
                cmd = new SqlCommand("INSERT INTO checkup VALUES (@checkupNo, @patientID, @empID, @date, @visualAcuity, @cEER, @prescriptionDetails, @frameDetails)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@checkupNo", tbCheckupNo.Text);
                cmd.Parameters.AddWithValue("@patientID", tbPatientID.Text);
                cmd.Parameters.AddWithValue("@empID", Connection.empID);
                cmd.Parameters.AddWithValue("@date", formattedDateTime(DateTime.Today.ToString()));
                cmd.Parameters.AddWithValue("@visualAcuity", visualAcuity.Text);
                cmd.Parameters.AddWithValue("@cEER", cEER.Text);
                cmd.Parameters.AddWithValue("@prescriptionDetails", prescriptionDetails.Text);
                cmd.Parameters.AddWithValue("@frameDetails", frameDetails.Text);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Info Added", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            con.Close();
        }

        private void btnEditPrescription_Click(object sender, EventArgs e)
        {
            visualAcuity.ReadOnly = false;
            prescriptionDetails.ReadOnly = false;
            cEER.ReadOnly = false;
            frameDetails.ReadOnly = false;
          
        }

        private int GenerateRandomNo()
        {
            int _min = 000000;
            int _max = 999999;
            Random _rdm = new Random();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From checkup", con);
            string query = "Select * From checkup where checkupno = '" + tbCheckupNo.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                GenerateRandomNo();
            }
            con.Close();

            return _rdm.Next(_min, _max);
        }

        private string formattedDateTime(string formattedDate)
        {
            DateTime birthdate = DateTime.Parse(tbBday.Text);
            formattedDate = birthdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return formattedDate;
        }

    }
}
