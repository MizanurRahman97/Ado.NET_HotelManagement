using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Login : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtusername.Text;
            string password = txtPassword.Text;
            SqlConnection con =new SqlConnection(conStr);
            string SqlQuery="SELECT * FROM Employee Where EmpUserName='"+userName+"'and EmpPassword='"+password+"'";
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.Parameters.AddWithValue("@EmpUserName", userName);
            cmd.Parameters.AddWithValue ("@EmpPassword", password);
            con.Open();
            SqlDataReader rdr =cmd.ExecuteReader();

            if(rdr.HasRows==true)
            {
                con.Close();
                MessageBox.Show("Login SuccessFull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoard obj = new DashBoard();
                this.Hide();
                obj.ShowDialog();
            }
            else
            {
                con.Close();
                MessageBox.Show("Logi");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            EmployeeForm objSignUp = new EmployeeForm();
            this.Hide();
            objSignUp.ShowDialog();
        }
    }
}
