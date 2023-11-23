namespace HotelManagement
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRoomCategory = new System.Windows.Forms.Label();
            this.cmbRoomcategory = new System.Windows.Forms.ComboBox();
            this.cmbBookingID = new System.Windows.Forms.ComboBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.pbBoxCustomer = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dtpCustBookingdate = new System.Windows.Forms.DateTimePicker();
            this.lblCustBookingdate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCustPhoneNO = new System.Windows.Forms.TextBox();
            this.txtCustOccupation = new System.Windows.Forms.TextBox();
            this.txtCustomerNID = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustPhoneNO = new System.Windows.Forms.Label();
            this.lblCustOccupation = new System.Windows.Forms.Label();
            this.lblCustomerNID = new System.Windows.Forms.Label();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.lblCustDateofBirth = new System.Windows.Forms.Label();
            this.txtCustomerLName = new System.Windows.Forms.TextBox();
            this.txtCustMothersName = new System.Windows.Forms.TextBox();
            this.txtCustfathersName = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustomerFName = new System.Windows.Forms.TextBox();
            this.lblCustFathersName = new System.Windows.Forms.Label();
            this.lblCustMothersName = new System.Windows.Forms.Label();
            this.lblCustomerLName = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCustomerFName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRoomCategory = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddBooking = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoxCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dash";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRoomCategory);
            this.groupBox1.Controls.Add(this.cmbRoomcategory);
            this.groupBox1.Controls.Add(this.cmbBookingID);
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Controls.Add(this.pbBoxCustomer);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.dtpCustBookingdate);
            this.groupBox1.Controls.Add(this.lblCustBookingdate);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCustPhoneNO);
            this.groupBox1.Controls.Add(this.txtCustOccupation);
            this.groupBox1.Controls.Add(this.txtCustomerNID);
            this.groupBox1.Controls.Add(this.lblCustomerEmail);
            this.groupBox1.Controls.Add(this.lblCustPhoneNO);
            this.groupBox1.Controls.Add(this.lblCustOccupation);
            this.groupBox1.Controls.Add(this.lblCustomerNID);
            this.groupBox1.Controls.Add(this.dtpDateofBirth);
            this.groupBox1.Controls.Add(this.lblCustDateofBirth);
            this.groupBox1.Controls.Add(this.txtCustomerLName);
            this.groupBox1.Controls.Add(this.txtCustMothersName);
            this.groupBox1.Controls.Add(this.txtCustfathersName);
            this.groupBox1.Controls.Add(this.txtCustId);
            this.groupBox1.Controls.Add(this.txtCustomerFName);
            this.groupBox1.Controls.Add(this.lblCustFathersName);
            this.groupBox1.Controls.Add(this.lblCustMothersName);
            this.groupBox1.Controls.Add(this.lblCustomerLName);
            this.groupBox1.Controls.Add(this.lblCustId);
            this.groupBox1.Controls.Add(this.lblCustomerFName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "customer";
            // 
            // lblRoomCategory
            // 
            this.lblRoomCategory.AutoSize = true;
            this.lblRoomCategory.Location = new System.Drawing.Point(10, 344);
            this.lblRoomCategory.Name = "lblRoomCategory";
            this.lblRoomCategory.Size = new System.Drawing.Size(80, 13);
            this.lblRoomCategory.TabIndex = 16;
            this.lblRoomCategory.Text = "Room Category";
            // 
            // cmbRoomcategory
            // 
            this.cmbRoomcategory.FormattingEnabled = true;
            this.cmbRoomcategory.Location = new System.Drawing.Point(99, 341);
            this.cmbRoomcategory.Name = "cmbRoomcategory";
            this.cmbRoomcategory.Size = new System.Drawing.Size(137, 21);
            this.cmbRoomcategory.TabIndex = 15;
            // 
            // cmbBookingID
            // 
            this.cmbBookingID.FormattingEnabled = true;
            this.cmbBookingID.Location = new System.Drawing.Point(98, 313);
            this.cmbBookingID.Name = "cmbBookingID";
            this.cmbBookingID.Size = new System.Drawing.Size(138, 21);
            this.cmbBookingID.TabIndex = 14;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(7, 314);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(57, 13);
            this.lblBookingID.TabIndex = 13;
            this.lblBookingID.Text = "BookingID";
            // 
            // pbBoxCustomer
            // 
            this.pbBoxCustomer.Location = new System.Drawing.Point(6, 373);
            this.pbBoxCustomer.Name = "pbBoxCustomer";
            this.pbBoxCustomer.Size = new System.Drawing.Size(115, 87);
            this.pbBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoxCustomer.TabIndex = 12;
            this.pbBoxCustomer.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(138, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(139, 380);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dtpCustBookingdate
            // 
            this.dtpCustBookingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustBookingdate.Location = new System.Drawing.Point(98, 288);
            this.dtpCustBookingdate.Name = "dtpCustBookingdate";
            this.dtpCustBookingdate.Size = new System.Drawing.Size(138, 20);
            this.dtpCustBookingdate.TabIndex = 8;
            // 
            // lblCustBookingdate
            // 
            this.lblCustBookingdate.AutoSize = true;
            this.lblCustBookingdate.Location = new System.Drawing.Point(3, 289);
            this.lblCustBookingdate.Name = "lblCustBookingdate";
            this.lblCustBookingdate.Size = new System.Drawing.Size(90, 13);
            this.lblCustBookingdate.TabIndex = 7;
            this.lblCustBookingdate.Text = "CustBookingDate";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCustPhoneNO
            // 
            this.txtCustPhoneNO.Location = new System.Drawing.Point(100, 232);
            this.txtCustPhoneNO.Name = "txtCustPhoneNO";
            this.txtCustPhoneNO.Size = new System.Drawing.Size(137, 20);
            this.txtCustPhoneNO.TabIndex = 5;
            // 
            // txtCustOccupation
            // 
            this.txtCustOccupation.Location = new System.Drawing.Point(99, 206);
            this.txtCustOccupation.Name = "txtCustOccupation";
            this.txtCustOccupation.Size = new System.Drawing.Size(137, 20);
            this.txtCustOccupation.TabIndex = 5;
            // 
            // txtCustomerNID
            // 
            this.txtCustomerNID.Location = new System.Drawing.Point(99, 179);
            this.txtCustomerNID.Name = "txtCustomerNID";
            this.txtCustomerNID.Size = new System.Drawing.Size(137, 20);
            this.txtCustomerNID.TabIndex = 5;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(4, 260);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Customer Email :";
            // 
            // lblCustPhoneNO
            // 
            this.lblCustPhoneNO.AutoSize = true;
            this.lblCustPhoneNO.Location = new System.Drawing.Point(3, 232);
            this.lblCustPhoneNO.Name = "lblCustPhoneNO";
            this.lblCustPhoneNO.Size = new System.Drawing.Size(84, 13);
            this.lblCustPhoneNO.TabIndex = 4;
            this.lblCustPhoneNO.Text = "Cust Phone NO:";
            // 
            // lblCustOccupation
            // 
            this.lblCustOccupation.AutoSize = true;
            this.lblCustOccupation.Location = new System.Drawing.Point(4, 204);
            this.lblCustOccupation.Name = "lblCustOccupation";
            this.lblCustOccupation.Size = new System.Drawing.Size(92, 13);
            this.lblCustOccupation.TabIndex = 4;
            this.lblCustOccupation.Text = "Cust Occupation :";
            // 
            // lblCustomerNID
            // 
            this.lblCustomerNID.AutoSize = true;
            this.lblCustomerNID.Location = new System.Drawing.Point(5, 181);
            this.lblCustomerNID.Name = "lblCustomerNID";
            this.lblCustomerNID.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerNID.TabIndex = 4;
            this.lblCustomerNID.Text = "Customer-NID:";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofBirth.Location = new System.Drawing.Point(98, 151);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(138, 20);
            this.dtpDateofBirth.TabIndex = 3;
            // 
            // lblCustDateofBirth
            // 
            this.lblCustDateofBirth.AutoSize = true;
            this.lblCustDateofBirth.Location = new System.Drawing.Point(4, 151);
            this.lblCustDateofBirth.Name = "lblCustDateofBirth";
            this.lblCustDateofBirth.Size = new System.Drawing.Size(90, 13);
            this.lblCustDateofBirth.TabIndex = 2;
            this.lblCustDateofBirth.Text = "Cust-Date of Birth";
            // 
            // txtCustomerLName
            // 
            this.txtCustomerLName.Location = new System.Drawing.Point(98, 67);
            this.txtCustomerLName.Name = "txtCustomerLName";
            this.txtCustomerLName.Size = new System.Drawing.Size(138, 20);
            this.txtCustomerLName.TabIndex = 1;
            // 
            // txtCustMothersName
            // 
            this.txtCustMothersName.Location = new System.Drawing.Point(98, 121);
            this.txtCustMothersName.Name = "txtCustMothersName";
            this.txtCustMothersName.Size = new System.Drawing.Size(138, 20);
            this.txtCustMothersName.TabIndex = 1;
            // 
            // txtCustfathersName
            // 
            this.txtCustfathersName.Location = new System.Drawing.Point(98, 94);
            this.txtCustfathersName.Name = "txtCustfathersName";
            this.txtCustfathersName.Size = new System.Drawing.Size(138, 20);
            this.txtCustfathersName.TabIndex = 1;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(98, 15);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(138, 20);
            this.txtCustId.TabIndex = 1;
            // 
            // txtCustomerFName
            // 
            this.txtCustomerFName.Location = new System.Drawing.Point(99, 41);
            this.txtCustomerFName.Name = "txtCustomerFName";
            this.txtCustomerFName.Size = new System.Drawing.Size(138, 20);
            this.txtCustomerFName.TabIndex = 1;
            // 
            // lblCustFathersName
            // 
            this.lblCustFathersName.AutoSize = true;
            this.lblCustFathersName.Location = new System.Drawing.Point(3, 94);
            this.lblCustFathersName.Name = "lblCustFathersName";
            this.lblCustFathersName.Size = new System.Drawing.Size(91, 13);
            this.lblCustFathersName.TabIndex = 0;
            this.lblCustFathersName.Text = "CustFathersName";
            // 
            // lblCustMothersName
            // 
            this.lblCustMothersName.AutoSize = true;
            this.lblCustMothersName.Location = new System.Drawing.Point(4, 122);
            this.lblCustMothersName.Name = "lblCustMothersName";
            this.lblCustMothersName.Size = new System.Drawing.Size(94, 13);
            this.lblCustMothersName.TabIndex = 0;
            this.lblCustMothersName.Text = "CustMothersName";
            // 
            // lblCustomerLName
            // 
            this.lblCustomerLName.AutoSize = true;
            this.lblCustomerLName.Location = new System.Drawing.Point(8, 70);
            this.lblCustomerLName.Name = "lblCustomerLName";
            this.lblCustomerLName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerLName.TabIndex = 0;
            this.lblCustomerLName.Text = "CustomerLName";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(10, 21);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(37, 13);
            this.lblCustId.TabIndex = 0;
            this.lblCustId.Text = "CustId";
            // 
            // lblCustomerFName
            // 
            this.lblCustomerFName.AutoSize = true;
            this.lblCustomerFName.Location = new System.Drawing.Point(7, 46);
            this.lblCustomerFName.Name = "lblCustomerFName";
            this.lblCustomerFName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerFName.TabIndex = 0;
            this.lblCustomerFName.Text = "CustomerFName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRoomCategory);
            this.groupBox2.Controls.Add(this.btnAddRoom);
            this.groupBox2.Controls.Add(this.lblAddCategory);
            this.groupBox2.Location = new System.Drawing.Point(280, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room";
            // 
            // txtRoomCategory
            // 
            this.txtRoomCategory.Location = new System.Drawing.Point(102, 29);
            this.txtRoomCategory.Name = "txtRoomCategory";
            this.txtRoomCategory.Size = new System.Drawing.Size(86, 20);
            this.txtRoomCategory.TabIndex = 3;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(113, 69);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(6, 29);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(71, 13);
            this.lblAddCategory.TabIndex = 0;
            this.lblAddCategory.Text = "Add Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBooking);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.lblAddBooking);
            this.groupBox3.Location = new System.Drawing.Point(523, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 97);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booking";
            // 
            // txtBooking
            // 
            this.txtBooking.Location = new System.Drawing.Point(86, 20);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(100, 20);
            this.txtBooking.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(113, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddBooking
            // 
            this.lblAddBooking.AutoSize = true;
            this.lblAddBooking.Location = new System.Drawing.Point(9, 24);
            this.lblAddBooking.Name = "lblAddBooking";
            this.lblAddBooking.Size = new System.Drawing.Size(68, 13);
            this.lblAddBooking.TabIndex = 0;
            this.lblAddBooking.Text = "Add Booking";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(16, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(97, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Location = new System.Drawing.Point(289, 67);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.Size = new System.Drawing.Size(607, 338);
            this.dgvDashboard.TabIndex = 5;
            this.dgvDashboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDashboard_CellClick);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(767, 438);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(104, 34);
            this.btnViewReport.TabIndex = 6;
            this.btnViewReport.Text = "ViewReport";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(580, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 46);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(813, 27);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeName.TabIndex = 8;
            this.lblEmployeeName.Text = "Unknown";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 545);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoxCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.Label lblCustDateofBirth;
        private System.Windows.Forms.TextBox txtCustomerLName;
        private System.Windows.Forms.TextBox txtCustMothersName;
        private System.Windows.Forms.TextBox txtCustfathersName;
        private System.Windows.Forms.TextBox txtCustomerFName;
        private System.Windows.Forms.Label lblCustFathersName;
        private System.Windows.Forms.Label lblCustMothersName;
        private System.Windows.Forms.Label lblCustomerLName;
        private System.Windows.Forms.Label lblCustomerFName;
        private System.Windows.Forms.DateTimePicker dtpCustBookingdate;
        private System.Windows.Forms.Label lblCustBookingdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCustPhoneNO;
        private System.Windows.Forms.TextBox txtCustOccupation;
        private System.Windows.Forms.TextBox txtCustomerNID;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustPhoneNO;
        private System.Windows.Forms.Label lblCustOccupation;
        private System.Windows.Forms.Label lblCustomerNID;
        private System.Windows.Forms.PictureBox pbBoxCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddBooking;
        private System.Windows.Forms.Label lblRoomCategory;
        private System.Windows.Forms.ComboBox cmbRoomcategory;
        private System.Windows.Forms.ComboBox cmbBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtRoomCategory;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}