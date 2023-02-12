using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        public String student_id { get; set; }
        public string student_name { get; set; }
        public double student_gpa { get; set; }

        public Student()
        {
            this.student_id = "__default-id";
            this.student_name = "__default-name";
            this.student_gpa = 0.0;
        }

        public Student(String studentID, String studentName, double studentGPA)
        {
            this.student_id = studentID;
            this.student_name = studentName;
            this.student_gpa = studentGPA;
        }

        public String toString()
        {
            return "Student ID: " + student_id + ", Student Name: " + student_name + ", Student GPA: " + student_gpa + ".";
        }
    }
}
