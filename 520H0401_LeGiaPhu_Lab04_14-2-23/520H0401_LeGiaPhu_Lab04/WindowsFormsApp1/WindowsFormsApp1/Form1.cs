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
        private SchoolDBEntities db = new SchoolDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SchoolDBEntities db = new SchoolDBEntities();

            //var student = db.Students.Where(x => x.StudentID == 1).FirstOrDefault();
            ////textBox1.Text = student.StudentName.ToString();

            //Student std = new Student { 
            //    StudentID = 100,
            //    StudentName = "John",  
            //};
            ////textBox1.Text = std.StudentName.ToString();
            ////db.Students.Add(std);
            ////db.SaveChanges();
            ///
            Load_Data();
        }

        private void Load_Data()
        {
            try
            {
                var student = db.Students.Select(s => s).ToList();
                dataGridView1.DataSource = student;
            }
            catch (Exception)
            {

            }
        }
    }
}
