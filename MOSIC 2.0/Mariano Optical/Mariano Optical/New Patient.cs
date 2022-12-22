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
    public partial class New_Patient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");
        private string empID = Connection.empID;
        private int patientID = 0;
        private int patientAge = 0;


        public New_Patient()
        {
            InitializeComponent();
        }

        private void New_Patient_Load(object sender, EventArgs e)
        {
            patientID = GenerateRandomNo();
            tbPatientID.Text = patientID.ToString();
            Connection.patientID = patientID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender;
            computeAge();
            
            if (rdMale.Checked)
                gender = "Male";
            else
                gender = "Female";


            string query = "INSERT INTO Patient VALUES (@patientID, @address, @occupation, @age, @gender, @height, @weight, @bp, @birthdate, @cNum, @email, @fname," +
                " @mName, @lName)";

            
            SqlCommand cmd = new SqlCommand(query,con);

            

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@patientID", tbPatientID.Text);
            cmd.Parameters.AddWithValue("@address", tbAddress.Text);
            cmd.Parameters.AddWithValue("@occupation", tbOccupation.Text);
            cmd.Parameters.AddWithValue("@age", patientAge);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@height", tbHeight.Text);
            cmd.Parameters.AddWithValue("@weight", tbPWeight.Text);
            cmd.Parameters.AddWithValue("@bp", tbPBP.Text);
            cmd.Parameters.AddWithValue("@birthdate", formattedDateTime(tbBday.Text));
            cmd.Parameters.AddWithValue("@cNum", tbCNum.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.Parameters.AddWithValue("@fName", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@mName", tbMidName.Text);
            cmd.Parameters.AddWithValue("@lName", tbLastName.Text);



            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Patient Added \n"
                           + "Patient ID: " + patientID, "Saved",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            goToShowDetails();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private int GenerateRandomNo()
        {
            int _min = 000000;
            int _max = 999999;
            Random _rdm = new Random();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Patient", con);
            string query = "Select * From patient where patientid = '" + tbPatientID.Text.Trim() + "'";
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

        private void goToShowDetails()
        {
            var frm = new ShowDetails();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            
        }

        private void computeAge()
        {
            
            DateTime birthdate = DateTime.Parse(tbBday.Text);
            

            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            patientAge = age;
        }

        private string formattedDateTime(string formattedDate)
        {
            DateTime birthdate = DateTime.Parse(tbBday.Text);
            formattedDate = birthdate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return formattedDate;
        }
        
    }
}
