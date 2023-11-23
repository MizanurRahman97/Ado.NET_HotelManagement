using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class EmployeeForm : Form
    {
        Employee objEmployee = new Employee();
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        string imgName;
        string filePath = "";
        string folderPath = @"C:\Users\LAB-1\Desktop\FinalProject-Ado.net\Mid\HotelManagementSln\HotelManagement\Images\";
        string imagePathFromData;
        public EmployeeForm()
        {
            InitializeComponent();
        }

       

       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                objEmployee.employeeFullName = txtEmpFullName.Text;
                objEmployee.employeeNID = txtEmpNID.Text;
                objEmployee.email = txtEmpEmail.Text;
                objEmployee.employeeaddress = txtEmpAddress.Text;
                objEmployee.employeePassword = txtEmpPassword.Text;
                objEmployee.employeeUserName = txtEmpUserName.Text;
                objEmployee.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                SqlConnection con = new SqlConnection(conStr);
                string SqlQuery = "Insert into Employee values(@EmpFullName,@EmpUserName,@EmpAddress,@EmpEmail,@EmpNID,@EmpPassword,@ImagePath)";
                SqlCommand cmd = new SqlCommand(SqlQuery, con);
                cmd.Parameters.AddWithValue("@EmpFullName", objEmployee.employeeFullName);
                cmd.Parameters.AddWithValue("@EmpNID", objEmployee.employeeNID);
                cmd.Parameters.AddWithValue("@EmpEmail", objEmployee.email);
                cmd.Parameters.AddWithValue("@EmpAddress", objEmployee.employeeaddress);
                cmd.Parameters.AddWithValue("@EmpPassword", objEmployee.employeePassword);
                cmd.Parameters.AddWithValue("@EmpUserName", objEmployee.employeeUserName);
                cmd.Parameters.AddWithValue("@ImagePath", objEmployee.ImagePath);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();
                if (rowCount > 0)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login objLogin = new Login();
                    this.Hide();
                    objLogin.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbEmployee.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }
    }
}
