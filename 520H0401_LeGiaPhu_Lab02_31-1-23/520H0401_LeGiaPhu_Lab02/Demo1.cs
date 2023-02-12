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
    public partial class Demo1 : Form
    {
        public Demo1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Exit", "I am gonna miss you");
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtbxUsername.Text) && String.IsNullOrEmpty(txtbxPassword.Text))
            {
                MessageBox.Show("Username and Password can not be empty");
            } else if (String.IsNullOrEmpty(txtbxUsername.Text) || String.IsNullOrEmpty(txtbxPassword.Text))
            {
                MessageBox.Show("Username or Password is empty");
            } else if(!rdbtnDarkTheme.Checked && !rdbtnLightTheme.Checked)
            {
                MessageBox.Show("Please check the theme");
            } else
            {
                String username = txtbxUsername.Text;
                String password = txtbxPassword.Text;
                String msgBoxOutput = "Username: " + username + "\nPassword: " + password + "";
                MessageBox.Show(msgBoxOutput, "Your input", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
