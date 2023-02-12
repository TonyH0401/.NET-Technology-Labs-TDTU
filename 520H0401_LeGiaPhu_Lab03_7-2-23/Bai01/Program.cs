namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<Student> student_manager = new List<Student>();

            student_manager.Add(new Student());

        }
        public static void findStudent(List<Student> studentList, String studentID)
        {
            foreach (Student item in studentList)
            {
                if(item.student_id.Equals(studentID))
                {
                    Console.WriteLine(item.student_id);
                    Console.WriteLine(item.student_name);
                    Console.WriteLine(item.student_gpa);
                    return;
                }
            }
        }
        public static void deleteStudent(List<Student> studentList, String studentID)
        {
            int index = studentList.FindIndex(item => item.student_id.Equals(studentID));
            if(index > -1)
            {
                studentList.RemoveAt(index);
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
        public static void updateStudent(List<Student> studentList, String studentID, Student std)
        {
            foreach (Student item in studentList)
            {
                if (studentID.Equals(item.student_id))
                {
                    item.student_name = std.student_name;
                    item.student_gpa = std.student_gpa;
                    Console.WriteLine("Updated");
                    break;
                }
            }
            
        }
        public static void listStudent(List<Student> studentList)
        {
            foreach(Student std in studentList) {
                Console.WriteLine(std.toString());
            }
        }
    }
}