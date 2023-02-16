using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDBEntities db = new SchoolDBEntities();
            var student = db.Students.Where(s => s.StudentID == 6).FirstOrDefault();
            Console.WriteLine(student.StudentID);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.StudentAddress);
            Console.ReadKey();
        }
    }
}
