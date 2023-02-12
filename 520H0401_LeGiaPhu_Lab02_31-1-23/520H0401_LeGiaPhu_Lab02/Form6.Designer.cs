namespace Lab01
{
    partial class Form6
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.cbbxYear = new System.Windows.Forms.ComboBox();
            this.cbbxClassID = new System.Windows.Forms.ComboBox();
            this.chkListbxSubject = new System.Windows.Forms.CheckedListBox();
            this.rdbtnSemester1 = new System.Windows.Forms.RadioButton();
            this.rdbtnSemester2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSemester4 = new System.Windows.Forms.RadioButton();
            this.rdbtnSemester3 = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(12, 43);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(12, 82);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(49, 13);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Fullname";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(12, 158);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(43, 13);
            this.lblClassID.TabIndex = 3;
            this.lblClassID.Text = "ClassID";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 118);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 249);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(48, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subjects";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(12, 205);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "Semester";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(101, 43);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(165, 20);
            this.txtMSSV.TabIndex = 6;
            this.txtMSSV.Leave += new System.EventHandler(this.txtMSSV_Leave);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(101, 82);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(248, 20);
            this.txtFullname.TabIndex = 7;
            this.txtFullname.Leave += new System.EventHandler(this.txtFullname_Leave);
            // 
            // cbbxYear
            // 
            this.cbbxYear.FormattingEnabled = true;
            this.cbbxYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019"});
            this.cbbxYear.Location = new System.Drawing.Point(101, 118);
            this.cbbxYear.Name = "cbbxYear";
            this.cbbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbbxYear.TabIndex = 8;
            this.cbbxYear.Leave += new System.EventHandler(this.cbbxYear_Leave);
            // 
            // cbbxClassID
            // 
            this.cbbxClassID.FormattingEnabled = true;
            this.cbbxClassID.Items.AddRange(new object[] {
            "20H50202",
            "20H50201",
            "20H50200"});
            this.cbbxClassID.Location = new System.Drawing.Point(101, 158);
            this.cbbxClassID.Name = "cbbxClassID";
            this.cbbxClassID.Size = new System.Drawing.Size(121, 21);
            this.cbbxClassID.TabIndex = 9;
            this.cbbxClassID.Leave += new System.EventHandler(this.cbbxClassID_Leave);
            // 
            // chkListbxSubject
            // 
            this.chkListbxSubject.FormattingEnabled = true;
            this.chkListbxSubject.Items.AddRange(new object[] {
            "LT Window",
            "LT Internet",
            "Mạng Máy Tính",
            "UML"});
            this.chkListbxSubject.Location = new System.Drawing.Point(101, 249);
            this.chkListbxSubject.Name = "chkListbxSubject";
            this.chkListbxSubject.ScrollAlwaysVisible = true;
            this.chkListbxSubject.Size = new System.Drawing.Size(134, 64);
            this.chkListbxSubject.TabIndex = 10;
            // 
            // rdbtnSemester1
            // 
            this.rdbtnSemester1.AutoSize = true;
            this.rdbtnSemester1.Location = new System.Drawing.Point(101, 205);
            this.rdbtnSemester1.Name = "rdbtnSemester1";
            this.rdbtnSemester1.Size = new System.Drawing.Size(28, 17);
            this.rdbtnSemester1.TabIndex = 11;
            this.rdbtnSemester1.TabStop = true;
            this.rdbtnSemester1.Text = "I";
            this.rdbtnSemester1.UseVisualStyleBackColor = true;
            // 
            // rdbtnSemester2
            // 
            this.rdbtnSemester2.AutoSize = true;
            this.rdbtnSemester2.Location = new System.Drawing.Point(163, 205);
            this.rdbtnSemester2.Name = "rdbtnSemester2";
            this.rdbtnSemester2.Size = new System.Drawing.Size(31, 17);
            this.rdbtnSemester2.TabIndex = 12;
            this.rdbtnSemester2.TabStop = true;
            this.rdbtnSemester2.Text = "II";
            this.rdbtnSemester2.UseVisualStyleBackColor = true;
            // 
            // rdbtnSemester4
            // 
            this.rdbtnSemester4.AutoSize = true;
            this.rdbtnSemester4.Location = new System.Drawing.Point(302, 205);
            this.rdbtnSemester4.Name = "rdbtnSemester4";
            this.rdbtnSemester4.Size = new System.Drawing.Size(35, 17);
            this.rdbtnSemester4.TabIndex = 14;
            this.rdbtnSemester4.TabStop = true;
            this.rdbtnSemester4.Text = "IV";
            this.rdbtnSemester4.UseVisualStyleBackColor = true;
            // 
            // rdbtnSemester3
            // 
            this.rdbtnSemester3.AutoSize = true;
            this.rdbtnSemester3.Location = new System.Drawing.Point(232, 205);
            this.rdbtnSemester3.Name = "rdbtnSemester3";
            this.rdbtnSemester3.Size = new System.Drawing.Size(34, 17);
            this.rdbtnSemester3.TabIndex = 13;
            this.rdbtnSemester3.TabStop = true;
            this.rdbtnSemester3.Text = "III";
            this.rdbtnSemester3.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(77, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Đăng &ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Th&oát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 430);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbtnSemester4);
            this.Controls.Add(this.rdbtnSemester3);
            this.Controls.Add(this.rdbtnSemester2);
            this.Controls.Add(this.rdbtnSemester1);
            this.Controls.Add(this.chkListbxSubject);
            this.Controls.Add(this.cbbxClassID);
            this.Controls.Add(this.cbbxYear);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblMSSV);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.ComboBox cbbxYear;
        private System.Windows.Forms.ComboBox cbbxClassID;
        private System.Windows.Forms.CheckedListBox chkListbxSubject;
        private System.Windows.Forms.RadioButton rdbtnSemester1;
        private System.Windows.Forms.RadioButton rdbtnSemester2;
        private System.Windows.Forms.RadioButton rdbtnSemester4;
        private System.Windows.Forms.RadioButton rdbtnSemester3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}