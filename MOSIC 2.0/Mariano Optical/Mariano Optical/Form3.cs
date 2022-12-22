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
    public partial class Form3 : Form
    {
        //
        private int empID = 0;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@empid, @firstname, @midname, @lastname, " +
                                            "@emppass)", con);
            
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@empid", empID);
            cmd.Parameters.AddWithValue("@firstname", tbFName.Text);
            cmd.Parameters.AddWithValue("@midname", tbMName.Text);
            cmd.Parameters.AddWithValue("@lastname", tbLName.Text);
            cmd.Parameters.AddWithValue("@emppass", tbPassword.Text);


            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.ExecuteNonQuery();
                con.Close();
            

            MessageBox.Show("New Employee Account is successfully created \n"
                            + "Employee ID: "+ empID, "Saved", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            close();
        }

        private int GenerateRandomNo()
        {
            int _min = 0000;
            int _max = 9999;
            Random _rdm = new Random();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Employee", con);
            string query = "Select * From Employee where empid = '" + tbEmpID.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                GenerateRandomNo();
            }

                return _rdm.Next(_min, _max);
        }

        private void close()
        {
            var frm = new Login();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            empID=GenerateRandomNo();
            tbEmpID.Text = empID.ToString();
        }
    }
}
