namespace HotelManagement
{
    partial class EmployeeForm
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblCreateRegister = new System.Windows.Forms.Label();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmpNID = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmpUserName = new System.Windows.Forms.TextBox();
            this.txtEmpFullName = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmpPassword = new System.Windows.Forms.Label();
            this.lblEmpNID = new System.Windows.Forms.Label();
            this.lblEmpemail = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblEmpUserName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.Location = new System.Drawing.Point(515, 366);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(176, 38);
            this.btnSignUp.TabIndex = 38;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblCreateRegister
            // 
            this.lblCreateRegister.AutoSize = true;
            this.lblCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateRegister.Location = new System.Drawing.Point(317, 24);
            this.lblCreateRegister.Name = "lblCreateRegister";
            this.lblCreateRegister.Size = new System.Drawing.Size(247, 31);
            this.lblCreateRegister.TabIndex = 37;
            this.lblCreateRegister.Text = "Create Register...";
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(405, 304);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.PasswordChar = '@';
            this.txtEmpPassword.Size = new System.Drawing.Size(172, 20);
            this.txtEmpPassword.TabIndex = 35;
            // 
            // txtEmpNID
            // 
            this.txtEmpNID.Location = new System.Drawing.Point(378, 248);
            this.txtEmpNID.Name = "txtEmpNID";
            this.txtEmpNID.Size = new System.Drawing.Size(194, 20);
            this.txtEmpNID.TabIndex = 34;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(376, 192);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmpEmail.TabIndex = 33;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(377, 141);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(198, 20);
            this.txtEmpAddress.TabIndex = 32;
            // 
            // txtEmpUserName
            // 
            this.txtEmpUserName.Location = new System.Drawing.Point(646, 94);
            this.txtEmpUserName.Name = "txtEmpUserName";
            this.txtEmpUserName.Size = new System.Drawing.Size(137, 20);
            this.txtEmpUserName.TabIndex = 31;
            // 
            // txtEmpFullName
            // 
            this.txtEmpFullName.Location = new System.Drawing.Point(378, 94);
            this.txtEmpFullName.Name = "txtEmpFullName";
            this.txtEmpFullName.Size = new System.Drawing.Size(176, 20);
            this.txtEmpFullName.TabIndex = 30;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(638, 255);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(61, 13);
            this.lblImagePath.TabIndex = 29;
            this.lblImagePath.Text = " ImagePath";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(706, 251);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Location = new System.Drawing.Point(669, 157);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(107, 87);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 27;
            this.pbEmployee.TabStop = false;
            // 
            // lblEmpPassword
            // 
            this.lblEmpPassword.AutoSize = true;
            this.lblEmpPassword.Location = new System.Drawing.Point(320, 307);
            this.lblEmpPassword.Name = "lblEmpPassword";
            this.lblEmpPassword.Size = new System.Drawing.Size(74, 13);
            this.lblEmpPassword.TabIndex = 25;
            this.lblEmpPassword.Text = "EmpPassword";
            // 
            // lblEmpNID
            // 
            this.lblEmpNID.AutoSize = true;
            this.lblEmpNID.Location = new System.Drawing.Point(306, 248);
            this.lblEmpNID.Name = "lblEmpNID";
            this.lblEmpNID.Size = new System.Drawing.Size(47, 13);
            this.lblEmpNID.TabIndex = 24;
            this.lblEmpNID.Text = "EmpNID";
            // 
            // lblEmpemail
            // 
            this.lblEmpemail.AutoSize = true;
            this.lblEmpemail.Location = new System.Drawing.Point(302, 195);
            this.lblEmpemail.Name = "lblEmpemail";
            this.lblEmpemail.Size = new System.Drawing.Size(53, 13);
            this.lblEmpemail.TabIndex = 23;
            this.lblEmpemail.Text = "EmpEmail";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Location = new System.Drawing.Point(301, 146);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(66, 13);
            this.lblEmpAddress.TabIndex = 22;
            this.lblEmpAddress.Text = "EmpAddress";
            // 
            // lblEmpUserName
            // 
            this.lblEmpUserName.AutoSize = true;
            this.lblEmpUserName.Location = new System.Drawing.Point(559, 98);
            this.lblEmpUserName.Name = "lblEmpUserName";
            this.lblEmpUserName.Size = new System.Drawing.Size(81, 13);
            this.lblEmpUserName.TabIndex = 21;
            this.lblEmpUserName.Text = "EmpUser Name";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(298, 96);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 13);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "EmpFull Name";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::HotelManagement.Properties.Resources.HotelReception;
            this.pbImage.Location = new System.Drawing.Point(-5, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(287, 452);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 39;
            this.pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblCreateRegister);
            this.Controls.Add(this.txtEmpPassword);
            this.Controls.Add(this.txtEmpNID);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpUserName);
            this.Controls.Add(this.txtEmpFullName);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmpPassword);
            this.Controls.Add(this.lblEmpNID);
            this.Controls.Add(this.lblEmpemail);
            this.Controls.Add(this.lblEmpAddress);
            this.Controls.Add(this.lblEmpUserName);
            this.Controls.Add(this.lbl);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblCreateRegister;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.TextBox txtEmpNID;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmpUserName;
        private System.Windows.Forms.TextBox txtEmpFullName;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEmpPassword;
        private System.Windows.Forms.Label lblEmpNID;
        private System.Windows.Forms.Label lblEmpemail;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblEmpUserName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}