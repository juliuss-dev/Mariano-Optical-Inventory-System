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
    
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KPLELPT\\SQLEXPRESS;Initial Catalog=Mariano Optical Database;Integrated Security=True");
        

        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Employee", con);
            string query = "Select * From Employee where empid = '" + tbEmpID.Text.Trim() + "' and emppass = '" + tbPass.Text.Trim() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                dt.Clear();
                MessageBox.Show("Login Succesfull" + tbEmpID.Text, "Succesful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.empID = tbEmpID.Text;
                close();

                con.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password \nPlease Try Again" ,"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            
        }

        private void close()
        {
            var frm = new Dashboard();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            
        }

    }
}
