using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtMSSV;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Leave", "Exit Message Box");
            Application.Exit();
        }

        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            if(txtMSSV.Text == "")
            {
                MessageBox.Show("Can not leave MSSV empty", "Warning Box");
                this.ActiveControl = txtMSSV;
            }
        }

        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if(txtFullname.Text == "")
            {
                MessageBox.Show("Can not leave Fullname empty", "Warning Box");
                this.ActiveControl = txtFullname;
            }
        }

        private void cbbxYear_Leave(object sender, EventArgs e)
        {
            if(cbbxYear.Text == "")
            {
                MessageBox.Show("Please Choose a Year", "Warning Box");
                this.ActiveControl = cbbxYear;
            }
        }

        private void cbbxClassID_Leave(object sender, EventArgs e)
        {
            if(cbbxClassID.Text == "")
            {
                MessageBox.Show("Please Choose Your Class ID", "Warning Box");
                this.ActiveControl = cbbxClassID;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String s1 = "";
            bool radioToken = false;
            List<RadioButton> rdlist = new List<RadioButton>();
            rdlist.Add(rdbtnSemester1);
            rdlist.Add(rdbtnSemester2);
            rdlist.Add(rdbtnSemester3);
            rdlist.Add(rdbtnSemester4);
            foreach(RadioButton rd in rdlist)
            {
                if(rd.Checked == true)
                {
                    s1 = rd.Text;
                    radioToken = true;
                    break;
                }
            }
            if(radioToken == false)
            {
                MessageBox.Show("Choose a Semester", "Warning Box");
            }

            string s = "";
            if (chkListbxSubject.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Choose a Subject", "Warning Box");
            }
            else
            {  
                for (int x = 0; x < chkListbxSubject.CheckedItems.Count; x++)
                {
                    s = s + "\tChecked Item " + (x + 1).ToString() + " = " + chkListbxSubject.CheckedItems[x].ToString() + "\n";
                }
            }

            String returnResult = "Sinh viên: " + txtFullname.Text + "\nMSSV: " + txtMSSV.Text + "\nYear: " + cbbxYear.Text + "\nSemester: " + s1 + "\nTotal Subjects:\n" +  s + "";
            MessageBox.Show(returnResult);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtFullname.Text = String.Empty;

            cbbxYear.Items.Clear();
            cbbxClassID.Items.Clear();

            rdbtnSemester1.Checked = false;
            rdbtnSemester2.Checked = false;
            rdbtnSemester3.Checked = false;
            rdbtnSemester4.Checked = false;

            cbbxYear.Items.Clear();
            cbbxClassID.Items.Clear();

            for (int x = 0; x < chkListbxSubject.Items.Count; x++)
            {

                chkListbxSubject.SetItemChecked(x, false);
            }
        }
    }
}
