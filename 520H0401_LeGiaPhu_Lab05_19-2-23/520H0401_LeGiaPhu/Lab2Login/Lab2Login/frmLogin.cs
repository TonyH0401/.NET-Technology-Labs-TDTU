using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Login
{
    public partial class frmLogin : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Exit?", "Warning Box", MessageBoxButtons.YesNo);
            if(dt == DialogResult.Yes)
                Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            //conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02Ex;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT UserID, Password FROM tblUsers WHERE " +
            "UserID='" + txtUserID.Text + "' and Password='" +
            txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!", "Sucess Login");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!", "Warning");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
