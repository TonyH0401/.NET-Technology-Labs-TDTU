namespace Lab01
{
    partial class Form4
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
            this.lblNhapten = new System.Windows.Forms.Label();
            this.lblLapTrinhBoi = new System.Windows.Forms.Label();
            this.txtbxInput = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnGreen = new System.Windows.Forms.RadioButton();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnYellow = new System.Windows.Forms.RadioButton();
            this.chkbxBold = new System.Windows.Forms.CheckBox();
            this.chkbxItalic = new System.Windows.Forms.CheckBox();
            this.chkbxUnderline = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhapten
            // 
            this.lblNhapten.AutoSize = true;
            this.lblNhapten.Location = new System.Drawing.Point(38, 21);
            this.lblNhapten.Name = "lblNhapten";
            this.lblNhapten.Size = new System.Drawing.Size(51, 13);
            this.lblNhapten.TabIndex = 0;
            this.lblNhapten.Text = "Nhập tên";
            // 
            // lblLapTrinhBoi
            // 
            this.lblLapTrinhBoi.AutoSize = true;
            this.lblLapTrinhBoi.ForeColor = System.Drawing.Color.Red;
            this.lblLapTrinhBoi.Location = new System.Drawing.Point(38, 231);
            this.lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            this.lblLapTrinhBoi.Size = new System.Drawing.Size(65, 13);
            this.lblLapTrinhBoi.TabIndex = 1;
            this.lblLapTrinhBoi.Text = "Lập trình bởi";
            // 
            // txtbxInput
            // 
            this.txtbxInput.BackColor = System.Drawing.Color.Red;
            this.txtbxInput.Location = new System.Drawing.Point(95, 21);
            this.txtbxInput.Name = "txtbxInput";
            this.txtbxInput.Size = new System.Drawing.Size(346, 20);
            this.txtbxInput.TabIndex = 2;
            this.txtbxInput.TextChanged += new System.EventHandler(this.txtbxInput_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(38, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(436, 74);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 5;
            this.lblFont.Text = "Font";
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Checked = true;
            this.rdbtnRed.ForeColor = System.Drawing.Color.Red;
            this.rdbtnRed.Location = new System.Drawing.Point(41, 99);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnRed.TabIndex = 6;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.CheckedChanged += new System.EventHandler(this.rdbtnRed_CheckedChanged);
            // 
            // rdbtnGreen
            // 
            this.rdbtnGreen.AutoSize = true;
            this.rdbtnGreen.ForeColor = System.Drawing.Color.Green;
            this.rdbtnGreen.Location = new System.Drawing.Point(41, 122);
            this.rdbtnGreen.Name = "rdbtnGreen";
            this.rdbtnGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbtnGreen.TabIndex = 7;
            this.rdbtnGreen.Text = "Green";
            this.rdbtnGreen.UseVisualStyleBackColor = true;
            this.rdbtnGreen.CheckedChanged += new System.EventHandler(this.rdbtnGreen_CheckedChanged);
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdbtnBlue.Location = new System.Drawing.Point(41, 145);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbtnBlue.TabIndex = 8;
            this.rdbtnBlue.Text = "Blue";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            this.rdbtnBlue.CheckedChanged += new System.EventHandler(this.rdbtnBlue_CheckedChanged);
            // 
            // rdbtnYellow
            // 
            this.rdbtnYellow.AutoSize = true;
            this.rdbtnYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rdbtnYellow.Location = new System.Drawing.Point(41, 168);
            this.rdbtnYellow.Name = "rdbtnYellow";
            this.rdbtnYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbtnYellow.TabIndex = 9;
            this.rdbtnYellow.Text = "Yellow";
            this.rdbtnYellow.UseVisualStyleBackColor = true;
            this.rdbtnYellow.CheckedChanged += new System.EventHandler(this.rdbtnYellow_CheckedChanged);
            // 
            // chkbxBold
            // 
            this.chkbxBold.AutoSize = true;
            this.chkbxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxBold.Location = new System.Drawing.Point(439, 100);
            this.chkbxBold.Name = "chkbxBold";
            this.chkbxBold.Size = new System.Drawing.Size(51, 17);
            this.chkbxBold.TabIndex = 10;
            this.chkbxBold.Text = "Bold";
            this.chkbxBold.UseVisualStyleBackColor = true;
            this.chkbxBold.CheckedChanged += new System.EventHandler(this.chkbxBold_CheckedChanged);
            // 
            // chkbxItalic
            // 
            this.chkbxItalic.AutoSize = true;
            this.chkbxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxItalic.Location = new System.Drawing.Point(439, 123);
            this.chkbxItalic.Name = "chkbxItalic";
            this.chkbxItalic.Size = new System.Drawing.Size(48, 17);
            this.chkbxItalic.TabIndex = 11;
            this.chkbxItalic.Text = "Italic";
            this.chkbxItalic.UseVisualStyleBackColor = true;
            this.chkbxItalic.CheckedChanged += new System.EventHandler(this.chkbxItalic_CheckedChanged);
            // 
            // chkbxUnderline
            // 
            this.chkbxUnderline.AutoSize = true;
            this.chkbxUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxUnderline.Location = new System.Drawing.Point(439, 146);
            this.chkbxUnderline.Name = "chkbxUnderline";
            this.chkbxUnderline.Size = new System.Drawing.Size(71, 17);
            this.chkbxUnderline.TabIndex = 12;
            this.chkbxUnderline.Text = "Underline";
            this.chkbxUnderline.UseVisualStyleBackColor = true;
            this.chkbxUnderline.CheckedChanged += new System.EventHandler(this.chkbxUnderline_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(439, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(133, 231);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(72, 13);
            this.lblOutput.TabIndex = 14;
            this.lblOutput.Text = "\"placeholder\"";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkbxUnderline);
            this.Controls.Add(this.chkbxItalic);
            this.Controls.Add(this.chkbxBold);
            this.Controls.Add(this.rdbtnYellow);
            this.Controls.Add(this.rdbtnBlue);
            this.Controls.Add(this.rdbtnGreen);
            this.Controls.Add(this.rdbtnRed);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtbxInput);
            this.Controls.Add(this.lblLapTrinhBoi);
            this.Controls.Add(this.lblNhapten);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapten;
        private System.Windows.Forms.Label lblLapTrinhBoi;
        private System.Windows.Forms.TextBox txtbxInput;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnGreen;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.RadioButton rdbtnYellow;
        private System.Windows.Forms.CheckBox chkbxBold;
        private System.Windows.Forms.CheckBox chkbxItalic;
        private System.Windows.Forms.CheckBox chkbxUnderline;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
    }
}