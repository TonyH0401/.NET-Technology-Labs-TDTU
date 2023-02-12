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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxEmployeeName;
        }

        private void txtbxEmployeeName_Leave(object sender, EventArgs e)
        {
            if(txtbxEmployeeName.Text == "")
            {
                MessageBox.Show("Employee Name should not be empty", "Warning Box");
                this.ActiveControl = txtbxEmployeeName;
            }
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

        private void msktxtbxDoB_Leave(object sender, EventArgs e)
        {
            if (msktxtbxDoB.MaskCompleted != true)
            {
                MessageBox.Show("Employee's DoB should not be empty", "Warning Box");
                this.ActiveControl = msktxtbxDoB;
                msktxtbxDoB.Select(0, 0);
            }
        }

        private void txtbxAddress_Leave(object sender, EventArgs e)
        {
            if(txtbxAddress.Text == "")
            {
                MessageBox.Show("Employee Address should not be empty", "Warning Box");
                this.ActiveControl = txtbxAddress;
            }
        }

        private void cbbxCity_Leave(object sender, EventArgs e)
        {
            String temp = cbbxCity.Text;
            if(temp == "")
            {
                MessageBox.Show("Can not leave City empty", "Warning Box");
                this.ActiveControl = cbbxCity;
            }
        }

        private void cbbxCountry_Leave(object sender, EventArgs e)
        {
            String temp = cbbxCountry.Text;
            if (temp == "")
            {
                MessageBox.Show("Can not leave Country empty", "Warning Box");
                this.ActiveControl = cbbxCountry;
            }
        }

        private void txtbxQualification_Leave(object sender, EventArgs e)
        {
            if(txtbxQualification.Text == "")
            {
                MessageBox.Show("Can not leave Qualification Empty", "Warning Box");
                this.ActiveControl = txtbxQualification;
            }
        }

        private void msktxtbxPhone_Leave(object sender, EventArgs e)
        {
            if(msktxtbxPhone.MaskCompleted != true)
            {
                MessageBox.Show("Can not leave Phone Number empty", "Warning Box");
                this.ActiveControl= msktxtbxPhone;
                msktxtbxPhone.Select(0, 0);
            }
        }

        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            if(txtbxEmail.Text == "")
            {
                MessageBox.Show("Can not leave Email Empty", "Warning Box");
                this.ActiveControl = txtbxEmail;
            } else
            {
                if (txtbxEmail.Text.Contains("@") == false)
                {
                    MessageBox.Show("There must be @ in email", "Missing character in Email");
                    this.ActiveControl = txtbxEmail;
                }
            }
            
        }

        private void linklblVNExpress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linklblVNExpress.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String name = txtbxEmployeeName.Text.ToString();
            String dob = msktxtbxDoB.Text.ToString();
            String address = txtbxAddress.Text.ToString();
            String city = cbbxCity.Text.ToString();
            String country = cbbxCountry.Text.ToString();
            String qualification = txtbxQualification.Text.ToString();
            String phone = msktxtbxPhone.Text.ToString();
            String email = txtbxEmail.Text.ToString();
            String date = dttmpkrDateJoining.Text.ToString();

            String temp = name + "\n" + dob + "\n" + address + "\n" + city + "\n" + country + "\n" + qualification + "\n" + phone + "\n" + email + "\n" + date + "";
            MessageBox.Show(temp, "Information Box");
        }
    }
}
