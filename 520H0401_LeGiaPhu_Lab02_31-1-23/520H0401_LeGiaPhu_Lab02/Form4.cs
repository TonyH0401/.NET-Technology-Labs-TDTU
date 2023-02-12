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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to Exit", "Exit Box");
            Application.Exit();
        }

        private void txtbxInput_TextChanged(object sender, EventArgs e)
        {
            //txtbxInput.Select(0, txtbxInput.TextLength);
            //txtbxInput.Select(txtbxInput.Text.Length, 0);
            lblOutput.Text = String.Format(txtbxInput.Text); 
        }

        private void rdbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Red;
            txtbxInput.BackColor = Color.Red;
            lblOutput.ForeColor = Color.Red;
        }

        private void rdbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Green;
            txtbxInput.BackColor = Color.Green;
            lblOutput.ForeColor = Color.Green;
        }

        private void rdbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Blue;
            txtbxInput.BackColor = Color.Blue;
            lblOutput.ForeColor = Color.Blue;
        }

        private void rdbtnYellow_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Yellow;
            txtbxInput.BackColor = Color.Yellow;
            lblOutput.ForeColor = Color.Yellow;
        }

        private void chkbxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxBold.Checked == true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, txtbxInput.Font.Style ^ FontStyle.Bold);
                lblOutput.Font = txtbxInput.Font;
            }

            if(chkbxBold.Checked != true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Bold ^ txtbxInput.Font.Style);
                lblOutput.Font = txtbxInput.Font;
            }
            //if(chkbxBold.Checked == true && chkbxItalic.Checked != true && chkbxUnderline.Checked != true)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Regular);
            //} else if()

            //if (chkbxBold.Checked == false && chkbxItalic.Checked == true)
            //{
            //    //MessageBox.Show(txtbxInput.Font.Style.ToString());
            //    txtbxInput.Font = new Font(txtbxInput.Font,FontStyle.Regular ^ FontStyle.Italic);
            //    //lblOutput.Font = txtbxInput.Font;
            //} else if(chkbxBold.Checked == false && chkbxUnderline.Checked == true)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Regular ^ FontStyle.Underline);
            //}
        }

        private void chkbxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxItalic.Checked == true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, txtbxInput.Font.Style ^ FontStyle.Italic);
                lblOutput.Font = txtbxInput.Font;
            }

            if(chkbxItalic.Checked != true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Italic ^ txtbxInput.Font.Style);
                lblOutput.Font = txtbxInput.Font;
            }
            //if (chkbxItalic.Checked == false && chkbxBold.Checked == true)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, txtbxInput.Font.Style ^ FontStyle.Bold);
            //    //lblOutput.Font = txtbxInput.Font;
            //    //lblOutput.Font = new Font(lblOutput.Font, FontStyle.Regular);
            //} else if(chkbxItalic.Checked == false && chkbxUnderline.Checked == true)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, txtbxInput.Font.Style ^ FontStyle.Underline);
            //}
        }

        private void chkbxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxUnderline.Checked == true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, txtbxInput.Font.Style ^ FontStyle.Underline);
                lblOutput.Font = txtbxInput.Font;
            }

            if (chkbxUnderline.Checked != true)
            {
                txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Underline ^ txtbxInput.Font.Style);
                lblOutput.Font = txtbxInput.Font;
            }

            //if (chkbxUnderline.Checked == true)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Underline);
            //    lblOutput.Font = new Font(lblOutput.Font, FontStyle.Underline);
            //}
            //if (chkbxUnderline.Checked == false)
            //{
            //    txtbxInput.Font = new Font(txtbxInput.Font, FontStyle.Regular);
            //    lblOutput.Font = new Font(lblOutput.Font, FontStyle.Regular);
            //}
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxInput;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
