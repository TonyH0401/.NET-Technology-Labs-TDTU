namespace Lab01
{
    partial class Form5
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxEmployeeName = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxQualification = new System.Windows.Forms.TextBox();
            this.msktxtbxDoB = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.cbbxCountry = new System.Windows.Forms.ComboBox();
            this.cbbxCity = new System.Windows.Forms.ComboBox();
            this.dttmpkrDateJoining = new System.Windows.Forms.DateTimePicker();
            this.linklblVNExpress = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(8, 19);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(26, 47);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 26);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth\r\n(mm/dd/yy)";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(65, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(44, 86);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 331);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 290);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(26, 233);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(65, 13);
            this.lblQualification.TabIndex = 5;
            this.lblQualification.Text = "Qualification";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(46, 178);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date of Joinning\r\n(mm/dd/yyyy)";
            // 
            // txtbxEmployeeName
            // 
            this.txtbxEmployeeName.Location = new System.Drawing.Point(119, 19);
            this.txtbxEmployeeName.Name = "txtbxEmployeeName";
            this.txtbxEmployeeName.Size = new System.Drawing.Size(218, 20);
            this.txtbxEmployeeName.TabIndex = 9;
            this.txtbxEmployeeName.Leave += new System.EventHandler(this.txtbxEmployeeName_Leave);
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(119, 86);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(218, 20);
            this.txtbxAddress.TabIndex = 10;
            this.txtbxAddress.Leave += new System.EventHandler(this.txtbxAddress_Leave);
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(119, 331);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(218, 20);
            this.txtbxEmail.TabIndex = 11;
            this.txtbxEmail.Leave += new System.EventHandler(this.txtbxEmail_Leave);
            // 
            // txtbxQualification
            // 
            this.txtbxQualification.Location = new System.Drawing.Point(119, 230);
            this.txtbxQualification.Multiline = true;
            this.txtbxQualification.Name = "txtbxQualification";
            this.txtbxQualification.Size = new System.Drawing.Size(218, 56);
            this.txtbxQualification.TabIndex = 12;
            this.txtbxQualification.Leave += new System.EventHandler(this.txtbxQualification_Leave);
            // 
            // msktxtbxDoB
            // 
            this.msktxtbxDoB.Location = new System.Drawing.Point(119, 53);
            this.msktxtbxDoB.Mask = "00/00/0000";
            this.msktxtbxDoB.Name = "msktxtbxDoB";
            this.msktxtbxDoB.Size = new System.Drawing.Size(100, 20);
            this.msktxtbxDoB.TabIndex = 14;
            this.msktxtbxDoB.Leave += new System.EventHandler(this.msktxtbxDoB_Leave);
            // 
            // msktxtbxPhone
            // 
            this.msktxtbxPhone.Location = new System.Drawing.Point(119, 295);
            this.msktxtbxPhone.Mask = "000-0000000";
            this.msktxtbxPhone.Name = "msktxtbxPhone";
            this.msktxtbxPhone.Size = new System.Drawing.Size(121, 20);
            this.msktxtbxPhone.TabIndex = 15;
            this.msktxtbxPhone.Leave += new System.EventHandler(this.msktxtbxPhone_Leave);
            // 
            // cbbxCountry
            // 
            this.cbbxCountry.FormattingEnabled = true;
            this.cbbxCountry.Items.AddRange(new object[] {
            "Vietnam",
            "Thailand"});
            this.cbbxCountry.Location = new System.Drawing.Point(119, 181);
            this.cbbxCountry.Name = "cbbxCountry";
            this.cbbxCountry.Size = new System.Drawing.Size(121, 21);
            this.cbbxCountry.TabIndex = 16;
            this.cbbxCountry.Leave += new System.EventHandler(this.cbbxCountry_Leave);
            // 
            // cbbxCity
            // 
            this.cbbxCity.FormattingEnabled = true;
            this.cbbxCity.Items.AddRange(new object[] {
            "Ho Chi Minh",
            "Nha Trang",
            "Ha Noi"});
            this.cbbxCity.Location = new System.Drawing.Point(119, 126);
            this.cbbxCity.Name = "cbbxCity";
            this.cbbxCity.Size = new System.Drawing.Size(121, 21);
            this.cbbxCity.TabIndex = 17;
            this.cbbxCity.Leave += new System.EventHandler(this.cbbxCity_Leave);
            // 
            // dttmpkrDateJoining
            // 
            this.dttmpkrDateJoining.CustomFormat = "mm/dd/yyyy";
            this.dttmpkrDateJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmpkrDateJoining.Location = new System.Drawing.Point(119, 363);
            this.dttmpkrDateJoining.Name = "dttmpkrDateJoining";
            this.dttmpkrDateJoining.Size = new System.Drawing.Size(218, 20);
            this.dttmpkrDateJoining.TabIndex = 18;
            // 
            // linklblVNExpress
            // 
            this.linklblVNExpress.AutoSize = true;
            this.linklblVNExpress.Location = new System.Drawing.Point(8, 431);
            this.linklblVNExpress.Name = "linklblVNExpress";
            this.linklblVNExpress.Size = new System.Drawing.Size(94, 13);
            this.linklblVNExpress.TabIndex = 19;
            this.linklblVNExpress.TabStop = true;
            this.linklblVNExpress.Text = "Link to VNExpress";
            this.linklblVNExpress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblVNExpress_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linklblVNExpress);
            this.Controls.Add(this.dttmpkrDateJoining);
            this.Controls.Add(this.cbbxCity);
            this.Controls.Add(this.cbbxCountry);
            this.Controls.Add(this.msktxtbxPhone);
            this.Controls.Add(this.msktxtbxDoB);
            this.Controls.Add(this.txtbxQualification);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxEmployeeName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblEmployeeName);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxEmployeeName;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxQualification;
        private System.Windows.Forms.MaskedTextBox msktxtbxDoB;
        private System.Windows.Forms.MaskedTextBox msktxtbxPhone;
        private System.Windows.Forms.ComboBox cbbxCountry;
        private System.Windows.Forms.ComboBox cbbxCity;
        private System.Windows.Forms.DateTimePicker dttmpkrDateJoining;
        private System.Windows.Forms.LinkLabel linklblVNExpress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}