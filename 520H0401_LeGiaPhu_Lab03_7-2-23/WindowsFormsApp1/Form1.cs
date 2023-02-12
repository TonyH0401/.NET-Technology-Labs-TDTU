using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbxStudentId;
            studentList.Add(new Student());

            frmDataGrid_Load();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void frmDataGrid_Load()
        {
            var bidingList = new BindingList<Student>(studentList);
            var source = new BindingSource(bidingList, null);
            dataGridViewStudent.DataSource = source;

            //dataGridViewStudent.ColumnCount = 3;
            //dataGridViewStudent.Columns[0].HeaderText = "Student ID";
            //dataGridViewStudent.Columns[1].HeaderText = "Student Name";
            //dataGridViewStudent.Columns[2].HeaderText = "Student GPA";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String studentID = txtbxStudentId.Text.Trim();
            String studentName = txtbxStudentName.Text.Trim();
            String studentGPA = txtStudentGpa.Text.Trim();
            
            if((String.IsNullOrEmpty(txtbxStudentId.Text.Trim()) == false) && (String.IsNullOrEmpty(txtbxStudentName.Text.Trim()) == false) && (String.IsNullOrEmpty(txtStudentGpa.Text.Trim()) == false))
            {
                double value = 0.0;
                bool result = Double.TryParse(studentGPA, out value);
                if (result == false)
                {
                    MessageBox.Show("Wrong data type for GPA. Try again", "ERROR");
                    return;
                }
                if(value < 0.0)
                {
                    MessageBox.Show("Wrong data type for GPA. Try again", "ERROR");
                    return;
                }
                foreach (Student item in studentList)
                {
                    if (studentID.Equals(item.student_id))
                    {
                        MessageBox.Show("Student with that ID existed", "ERROR");
                        return;
                    }
                }
                studentList.Add(new Student(studentID, studentName, value));
                clearTextBox();
                frmDataGrid_Load();
            }
            else
            {
                MessageBox.Show("Cannot be null", "ERROR");
            }
        }
        private void clearTextBox()
        {
            txtbxStudentId.Clear();
            txtbxStudentName.Clear();
            txtStudentGpa.Clear();
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                txtbxStudentId.ReadOnly = true;
                //txtbxStudentName.ReadOnly = true;
                //txtStudentGpa.ReadOnly = true;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                var selectedRow = dataGridViewStudent.SelectedRows[0].DataBoundItem as Student;
                txtbxStudentId.Text = selectedRow.student_id.ToString();
                txtbxStudentName.Text = selectedRow.student_name.ToString();
                txtStudentGpa.Text = selectedRow.student_gpa.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DISPLAY", "ERROR");
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
            this.ActiveControl = txtbxStudentId;
            btnAdd.Enabled = true;
            txtbxStudentId.ReadOnly = false;
            //txtbxStudentName.ReadOnly = false;
            //txtStudentGpa.ReadOnly = false;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String studentID = txtbxStudentId.Text;
            int index = studentList.FindIndex(item => item.student_id.Equals(studentID));
            studentList.RemoveAt(index);
            MessageBox.Show("DELETED: " + studentID, "NOTICE");
            clearTextBox();
            frmDataGrid_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String studentID = txtbxStudentId.Text;
            String studentName = txtbxStudentName.Text.Trim();
            String studentGPA = txtStudentGpa.Text.Trim();

            double value = 0.0;
            bool result = Double.TryParse(studentGPA, out value);
            if (result == false)
            {
                MessageBox.Show("Wrong data type for GPA. Try again", "ERROR");
                return;
            }
            if(value < 0.0)
            {
                MessageBox.Show("Wrong data type for GPA. Try again", "ERROR");
                return;
            }
            foreach (Student item in studentList)
            {
                if (item.student_id.Equals(studentID))
                {
                    item.student_name = studentName;
                    item.student_gpa = value;
                    MessageBox.Show("UPDATED: " + studentID, "NOTICE");
                    clearTextBox();
                    frmDataGrid_Load();
                    return;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtbxSearch.Text == "Enter Student ID here......")
            {
                MessageBox.Show("Please enter student ID", "ERROR");
            }
            else
            {
                String studentID = txtbxSearch.Text.Trim();
                int index = studentList.FindIndex(item => item.student_id.Equals(studentID));
                if(index < 0)
                {
                    MessageBox.Show("NO STUDENT WITH ID: " + studentID + " EXISTS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxSearch.Clear();
                    txtbxSearch.Text = "Enter Student ID here......";
                    txtbxSearch.ForeColor = Color.Silver;
                    this.ActiveControl = txtbxStudentId;
                }
                else
                {
                    //Refs: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-7.0
                    Student item = studentList[index];
                    String output = item.toString();
                    DialogResult result = MessageBox.Show("Value: " + output, "RESULT", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                    if(result == DialogResult.OK)
                    {
                        txtbxSearch.Clear();
                        txtbxSearch.Text = "Enter Student ID here......";
                        txtbxSearch.ForeColor = Color.Silver;
                    }
                }
            }
        }

        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            if (txtbxSearch.Text == "Enter Student ID here......")
            {
                txtbxSearch.Text = "";
                txtbxSearch.ForeColor = Color.Black;
            }
        }

        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            if (txtbxSearch.Text == "")
            {
                txtbxSearch.Text = "Enter Student ID here......";
                txtbxSearch.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Enjoy your stay", "WARNING");
            }
        }
    }
}
