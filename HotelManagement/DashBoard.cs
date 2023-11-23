using HotelManagement.Entities;
using HotelManagement.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class DashBoard : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        int empId =112;
        string imgName;
        string filePath = "";
        string folderPath = @"C:\Users\LAB-1\Desktop\FinalProject-Ado.net\Mid\HotelManagementSln\HotelManagement\Images\";
        string imagePathFromData;

        public DashBoard()
        {
            InitializeComponent();
        }
        private void LoadEmployeeName()
        {
            string userName = "";
            string SqlQuery = "SELECT FullName Form Employee Where EmployeeId='" + empId + "'";
            SqlConnection con =new SqlConnection(conStr);
            SqlCommand cmd =new SqlCommand(SqlQuery, con);
            con.Open();
            userName=(cmd.ExecuteScalar()).ToString();
            if(userName == "")
            {
                lblEmployeeName.Text = "Unknown";
            }
            lblEmployeeName.Text = userName;
            con.Close();
        }

        

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomCategory.Text) == true)
            {
                txtRoomCategory.Focus();
                errorProvider1.SetError(this.txtRoomCategory, "Please Enter Category Name");
                ClearMethod();
            }
            else
            {
                Room objRoom = new Room();
                objRoom.roomCategory = txtRoomCategory.Text;
                string sqlQuery = "Insert INTO Room (roomcategory) VALUES ('" + objRoom.roomCategory + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Room Insertion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadComboRoom();
            }
        }

        private void ClearMethod()
        {
            txtCustomerFName.Text="";
            txtCustomerLName.Text = "";
            txtCustfathersName.Text = "";
            txtCustMothersName.Text = "";
            //dtpDateofBirth.Text = DateTime.Now();
            txtCustomerNID.Text = "";
            txtCustOccupation.Text = "";
            txtCustPhoneNO.Text = "";
            txtEmail.Text = "";
           // dtpCustBookingdate.Text=DateTime.Now();
            cmbRoomcategory.SelectedValue=0;
            txtCustId.Text="";
            pbBoxCustomer.Image= Resources.noImage;
            cmbBookingID.SelectedValue=0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBooking.Text) == true)
            {
                txtBooking.Focus();
                errorProvider1.SetError(this.txtBooking, "Please Enter Booking");
                ClearMethod();
            }
            else
            {
                Booking_E objBooking = new Booking_E();
                objBooking.bookingType = txtBooking.Text;
                string sqlQuery = "Insert INTO Booking (bookingType) VALUES ('" + objBooking.bookingType + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Booking added successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Booking Insertion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadComboBooking();
            }
        }

        private void LoadComboBooking()
        {
            string sqlQuery = "SELECT * FROM Booking";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbBookingID.DisplayMember = "bookingType";
                cmbBookingID.ValueMember = "bookingId";
                cmbBookingID.DataSource = dt;
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;

            Customer objCustomer = new Customer();
            objCustomer.customerFName = txtCustomerFName.Text;
            objCustomer.customerLName = txtCustomerLName.Text;
            objCustomer.customerfathersName =txtCustfathersName.Text;
            objCustomer.customerMothersName=txtCustMothersName.Text;
            objCustomer.customerDateofBirth = Convert.ToDateTime(dtpDateofBirth.Text);
            objCustomer.customerNID = txtCustomerNID.Text;
            objCustomer.Occupation =txtCustOccupation.Text;
            objCustomer.PhoneNumber =txtCustPhoneNO.Text;
            objCustomer.Email =txtEmail.Text;
            objCustomer.customerBookingDate = Convert.ToDateTime(dtpCustBookingdate.Text);
            objCustomer.roomId = Convert.ToInt32(cmbRoomcategory.SelectedValue);
            objCustomer.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            objCustomer.employeeId = empId;
            objCustomer.bookingId=Convert.ToInt32(cmbBookingID.SelectedValue);
            string sqlQuery = "Insert into Customer values (@CustFName, @CustLName,@CustFathersName, @CustMothersName,@CustDateofBirth,@CustNID,@CustOccupation,@CustPhoneNo,@CustEmail,@CustBookingDate,@CustImagePath,@EmployeeId,@RoomId,@bookingId)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@ImgPath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImgPath", objCustomer.ImagePath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmd.Parameters.AddWithValue("@CustFName", objCustomer.customerFName);
            cmd.Parameters.AddWithValue("@CustLName", objCustomer.customerLName);
            cmd.Parameters.AddWithValue("@CustFathersName", objCustomer.customerfathersName);
            cmd.Parameters.AddWithValue("@CustMothersName", objCustomer.customerMothersName);
            cmd.Parameters.AddWithValue("@CustDateofBirth", objCustomer.customerDateofBirth);
            cmd.Parameters.AddWithValue("@CustNID", objCustomer.customerNID);
            cmd.Parameters.AddWithValue("@CustOccupation", objCustomer.Occupation);
            cmd.Parameters.AddWithValue("@CustPhoneNo", objCustomer.PhoneNumber);
            cmd.Parameters.AddWithValue("@CustEmail", objCustomer.Email);
            cmd.Parameters.AddWithValue("@CustBookingDate", objCustomer.customerBookingDate);
            cmd.Parameters.AddWithValue("@CustImagePath", objCustomer.ImagePath);
            cmd.Parameters.AddWithValue("@EmployeeId", objCustomer.employeeId);
            cmd.Parameters.AddWithValue("@RoomId", objCustomer.roomId);
            cmd.Parameters.AddWithValue("@bookingId", objCustomer.bookingId);
            con.Open();
            transaction = con.BeginTransaction();
            cmd.Transaction = transaction;
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                transaction.Commit();
                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK);
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Customer Insertion failed!", "Failure", MessageBoxButtons.OK);
                ClearMethod();
                transaction.Rollback();
            }

            con.Close();
            LoadGridView();
            ClearMethod();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustId.Text))
            {
                Customer objCustomer = new Customer();
                objCustomer.customerFName = txtCustomerFName.Text;
                objCustomer.customerLName = txtCustomerLName.Text;
                objCustomer.customerfathersName = txtCustfathersName.Text;
                objCustomer.customerMothersName = txtCustMothersName.Text;
                objCustomer.customerDateofBirth = Convert.ToDateTime(dtpDateofBirth.Text);
                objCustomer.customerNID = txtCustomerNID.Text;
                objCustomer.Occupation = txtCustOccupation.Text;
                objCustomer.PhoneNumber = txtCustPhoneNO.Text;
                objCustomer.Email = txtEmail.Text;
                objCustomer.customerBookingDate = Convert.ToDateTime(dtpCustBookingdate.Text);
                objCustomer.roomId = Convert.ToInt32(cmbRoomcategory.SelectedValue);
                objCustomer.ImagePath = folderPath + Path.GetFileName(openFileDialog1.FileName);
                objCustomer.customerId = Convert.ToInt16(txtCustId.Text);
                objCustomer.employeeId = empId;
                objCustomer.bookingId = Convert.ToInt32(cmbBookingID.SelectedValue);
                string sqlQuery = "Update  Customer set CustFName=@CustFName, CustLName=@CustLName,CustFathersName=@CustFathersName, CustMothersName=@CustMothersName,CustDateofBirth=@CustDateofBirth,CustNID=@CustNID,CustOccupation=@CustOccupation,CustPhoneNo=@CustPhoneNo,CustEmail=@CustEmail,CustBookingDate=@CustBookingDate,CustImagePath=@CustImagePath,EmployeeId=@EmployeeId,RoomId=@RoomId,bookingId=@bookingId where  CustId=@CustId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                if (filePath == "")
                {
                    cmd.Parameters.AddWithValue("@ImgPath", imagePathFromData);
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ImgPath", objCustomer.ImagePath);
                    try
                    {
                        File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                cmd.Parameters.AddWithValue("@CustFName", objCustomer.customerFName);
                cmd.Parameters.AddWithValue("@CustLName", objCustomer.customerLName);
                cmd.Parameters.AddWithValue("@CustFathersName", objCustomer.customerfathersName);
                cmd.Parameters.AddWithValue("@CustMothersName", objCustomer.customerMothersName);
                cmd.Parameters.AddWithValue("@CustDateofBirth", objCustomer.customerDateofBirth);
                cmd.Parameters.AddWithValue("@CustNID", objCustomer.customerNID);
                cmd.Parameters.AddWithValue("@CustOccupation", objCustomer.Occupation);
                cmd.Parameters.AddWithValue("@CustPhoneNo", objCustomer.PhoneNumber);
                cmd.Parameters.AddWithValue("@CustEmail", objCustomer.Email);
                cmd.Parameters.AddWithValue("@CustBookingDate", objCustomer.customerBookingDate);
                cmd.Parameters.AddWithValue("@CustImagePath", objCustomer.ImagePath);
                cmd.Parameters.AddWithValue("@EmployeeId", objCustomer.employeeId);
                cmd.Parameters.AddWithValue("@RoomId", objCustomer.roomId);
                cmd.Parameters.AddWithValue("@bookingId", objCustomer.bookingId);
                cmd.Parameters.AddWithValue("@CustId", objCustomer.customerId);

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    txtCustId.Text = "";
                    MessageBox.Show("Customer Updated successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Customer Updated failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
               LoadGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Customer Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustId.Text))
            {
                Customer objCust = new Customer();
                objCust.customerId = Convert.ToInt16(txtCustId.Text);
                string sqlQuery = "DELETE FROM  Customer WHERE CustId=@CustId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@CustId", objCust.customerId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    txtCustId.Text = "";
                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK);
                    ClearMethod();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Failure", MessageBoxButtons.OK);
                    ClearMethod();
                }
                con.Close();
                LoadGridView();
                ClearMethod();
            }
            else
            {
                MessageBox.Show("Please select Customer Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadComboRoom();
            LoadComboBooking();
            pbBoxCustomer.Image= Resources.noImage;
        }

        private void LoadComboRoom()
        {
            string sqlQuery = "SELECT * FROM Room";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbRoomcategory.DisplayMember = "roomCategory";
                cmbRoomcategory.ValueMember = "roomId";
                cmbRoomcategory.DataSource = dt;
            }
            con.Close();
        }

        private void LoadGridView()
        {
            string sqlQuery = "select cus.CustId, cus.CustFName, cus.CustLName,cus.CustFathersName, cus.CustMothersName, cus.CustDateofBirth, cus.CustNID,cus.CustOccupation,cus.CustPhoneNo,cus.CustEmail,cus.CustBookingDate,r.roomCategory,b.bookingType ,emp.EmpFullName,cus.CustImagePath from Customer cus join Room r on r.roomId=cus.RoomId join Employee emp on emp.EmployeeId=cus.EmployeeId join Booking b on b.bookingId=cus.bookingId";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    dr["Picture"] = File.ReadAllBytes(dr["CustImagePath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            dgvDashboard.RowTemplate.Height = 52;
            dgvDashboard.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvDashboard.Columns[15];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbBoxCustomer.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void dgvDashboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {               
                DataGridViewRow row = dgvDashboard.Rows[cellId];
                txtCustId.Text = row.Cells[0].Value.ToString();
                txtCustomerFName.Text = row.Cells[1].Value.ToString();
                txtCustomerLName.Text = row.Cells[2].Value.ToString();
                txtCustfathersName.Text= row.Cells[3].Value.ToString();
                txtCustMothersName.Text= row.Cells[4].Value.ToString(); ;
                dtpDateofBirth.Text=row.Cells[5].Value.ToString();
                txtCustomerNID.Text= row.Cells[6].Value.ToString();
                txtCustOccupation.Text= row.Cells[7].Value.ToString();
                txtCustPhoneNO.Text= row.Cells[8].Value.ToString();
                txtEmail.Text= row.Cells[9].Value.ToString();
                dtpCustBookingdate.Text= row.Cells[10].Value.ToString();
                cmbRoomcategory.Text= row.Cells[11].Value.ToString();
                cmbBookingID.Text= row.Cells[12].Value.ToString();                
                if (imagePathFromData == "No Image")
                {
                    pbBoxCustomer.Image = Resources.noImage;
                }
                byte[] data = (byte[])row.Cells[15].Value;
                MemoryStream stream = new MemoryStream(data);
                pbBoxCustomer.Image = Image.FromStream(stream);
                imagePathFromData = row.Cells[14].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            List<HotelViewModel> list = new List<HotelViewModel>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string SqlQuery = "select cus.CustId, cus.CustFName, cus.CustLName,cus.CustFathersName, cus.CustMothersName, cus.CustDateofBirth, cus.CustNID,cus.CustOccupation,cus.CustPhoneNo,cus.CustEmail,cus.CustBookingDate,cus.RoomId,cus.bookingId ,emp.EmployeeId,emp.EmpFullName,cus.CustImagePath from Customer cus join Room r on r.roomId=cus.RoomId join Employee emp on emp.EmployeeId=cus.EmployeeId join Booking b on b.bookingId=cus.bookingId";
                SqlDataAdapter sda = new SqlDataAdapter(SqlQuery, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HotelViewModel objHotel = new HotelViewModel();
                    objHotel.bookingId = Convert.ToInt32(dt.Rows[i]["bookingId"].ToString());
                    objHotel.CustomerId = Convert.ToInt32(dt.Rows[i]["CustId"].ToString());
                    objHotel.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"].ToString());
                    objHotel.roomId = Convert.ToInt32(dt.Rows[i]["roomId"].ToString());                  
                    objHotel.customerFName = dt.Rows[i]["CustFName"].ToString();
                    objHotel.customerLName = dt.Rows[i]["CustLName"].ToString();
                    objHotel.customerFathersName = dt.Rows[i]["CustFathersName"].ToString();
                    objHotel.customerMothersName = dt.Rows[i]["CustMothersName"].ToString();
                    objHotel.custDateofBirth = Convert.ToDateTime(dt.Rows[i]["CustDateofBirth"].ToString());
                    objHotel.customerNID = dt.Rows[i]["CustNID"].ToString();
                    objHotel.customerOccupation = dt.Rows[i]["CustOccupation"].ToString();

                    objHotel.customerPhoneNo = dt.Rows[i]["CustPhoneNo"].ToString();
                    objHotel.customerEmail = dt.Rows[i]["CustEmail"].ToString();
                    objHotel.custBookingDate = Convert.ToDateTime(dt.Rows[i]["CustBookingDate"].ToString());

                    objHotel.ImgagePath = dt.Rows[i]["CustImagePath"].ToString();
                   
                    list.Add(objHotel);
                }
            }
            using (HotelReport form = new HotelReport(list))
            {
                form.ShowDialog();
            }
        }
    }
    
}
