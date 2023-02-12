namespace Lab01
{
    partial class Demo1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblCopyrighted = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdbtnLightTheme = new System.Windows.Forms.RadioButton();
            this.rdbtnDarkTheme = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(173, 122);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(173, 151);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(245, 119);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(178, 20);
            this.txtbxUsername.TabIndex = 2;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(245, 151);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(178, 20);
            this.txtbxPassword.TabIndex = 3;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // lblCopyrighted
            // 
            this.lblCopyrighted.AutoSize = true;
            this.lblCopyrighted.Location = new System.Drawing.Point(609, 339);
            this.lblCopyrighted.Name = "lblCopyrighted";
            this.lblCopyrighted.Size = new System.Drawing.Size(63, 13);
            this.lblCopyrighted.TabIndex = 4;
            this.lblCopyrighted.Text = "Copyrighted";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(245, 187);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdbtnLightTheme
            // 
            this.rdbtnLightTheme.AutoSize = true;
            this.rdbtnLightTheme.Location = new System.Drawing.Point(143, 243);
            this.rdbtnLightTheme.Name = "rdbtnLightTheme";
            this.rdbtnLightTheme.Size = new System.Drawing.Size(84, 17);
            this.rdbtnLightTheme.TabIndex = 7;
            this.rdbtnLightTheme.TabStop = true;
            this.rdbtnLightTheme.Text = "Light Theme";
            this.rdbtnLightTheme.UseVisualStyleBackColor = true;
            // 
            // rdbtnDarkTheme
            // 
            this.rdbtnDarkTheme.AutoSize = true;
            this.rdbtnDarkTheme.Location = new System.Drawing.Point(142, 266);
            this.rdbtnDarkTheme.Name = "rdbtnDarkTheme";
            this.rdbtnDarkTheme.Size = new System.Drawing.Size(84, 17);
            this.rdbtnDarkTheme.TabIndex = 8;
            this.rdbtnDarkTheme.TabStop = true;
            this.rdbtnDarkTheme.Text = "Dark Theme";
            this.rdbtnDarkTheme.UseVisualStyleBackColor = true;
            // 
            // Demo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.rdbtnDarkTheme);
            this.Controls.Add(this.rdbtnLightTheme);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblCopyrighted);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "Demo1";
            this.Text = "My Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblCopyrighted;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbtnLightTheme;
        private System.Windows.Forms.RadioButton rdbtnDarkTheme;
    }
}

