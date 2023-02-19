using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Lab2Login
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.stConn);
                //conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02Ex;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT * FROM tblUsers ";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            LoadData();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            this.ActiveControl = txtUserID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            String userID = row.Cells[0].Value.ToString();
            String username = row.Cells[1].Value.ToString();
            String password = row.Cells[2].Value.ToString();
            // bit using int as 1 and 0
            String isActive = row.Cells[3].Value.ToString();
            String birthday= row.Cells[4].Value.ToString();

            txtUserID.Text = userID.Trim();
            txtUserID.Enabled = false;
            txtUsername.Text = username.Trim();
            txtPassword.Text = password.Trim();
            rdbtnisActive.Checked = (isActive == "True") ? true : false;
            dateTimePicker1.Text = birthday.Trim();

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            rdbtnisActive.Checked = false;
            dateTimePicker1.Value = DateTime.Today; 

            btnAdd.Enabled = true;
            txtUserID.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            this.ActiveControl = txtUserID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridViewStudent.SelectedRows[0];
            //MessageBox.Show(row.Cells[0].Value.ToString());
            //int gioiTinhBitValue = (rdbtnMale.Checked == true) ? 1 : 0;
            try
            {
                SqlConnection conn = new SqlConnection(Program.stConn);
                //conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02Ex;Integrated Security=True";
                conn.Open();

                String sSQL = "UPDATE tblUsers SET UserName = @UserName, Password=@Password, IsActive=@IsActive, CreateDate = @CreateDate WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@IsActive", (rdbtnisActive.Checked == true) ? 1 : 0);
                cmd.Parameters.AddWithValue("@CreateDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim());
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("User: " + txtUserID.Text.ToString().Trim() + " has been updated", "Confirm Update User");
                else
                    MessageBox.Show("Error when updating: " +txtUserID.Text.ToString().Trim() + "", "Error Update User");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int userID = (txtUserID.Text == "") ? 0 : 1;
            int username = (txtUsername.Text == "") ? 0 : 1;
            int password = (txtPassword.Text == "") ? 0 : 1;

            if ((userID * username * password) == 0)
            {
                MessageBox.Show("You need to fill all the textbox", "Missing User's Entity");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.stConn);
                    //conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02Ex;Integrated Security=True";
                    conn.Open();

                    String sSQL = "INSERT INTO tblUsers VALUES (@UserID, @UserName, @Password, @IsActive, @CreateDate)";
                    SqlCommand cmd = new SqlCommand(sSQL, conn);
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@IsActive", (rdbtnisActive.Checked == true) ? 1 : 0);
                    cmd.Parameters.AddWithValue("@CreateDate", dateTimePicker1.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        MessageBox.Show("Added new User", "Add Confirmation");
                    else
                        MessageBox.Show("Error when adding new User", "New user add error");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User exists, UserID existed", "Warning");
                    //MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
                }
                finally
                {
                    LoadData();
                }
            }
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            rdbtnisActive.Checked = false;
            dateTimePicker1.Value = DateTime.Today;

            btnAdd.Enabled = true;
            txtUserID.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            this.ActiveControl = txtUserID;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            try
            {
                SqlConnection conn = new SqlConnection(Program.stConn);
                //conn.ConnectionString = @"Data Source=DESKTOP-N5KPC9G\SQLEXPRESS; Initial Catalog=Lab02Ex;Integrated Security=True";
                conn.Open();

                String sSQL = "DELETE FROM tblUsers WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@UserID", row.Cells[0].Value.ToString());
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("User: " + row.Cells[0].Value.ToString().Trim() + " deleted", "Confirm Deletion");
                else
                    MessageBox.Show("Error");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occur: " + ex.Message + " - " + ex.Source);
            }
            finally
            {
                LoadData();
            }
        }
    }
}
