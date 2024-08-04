using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace List_CRUD_
{
    public class StudentManager
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent()
        {
            Console.WriteLine("Enter ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address : ");
            string address = Console.ReadLine();            
            
            Student newStudent = new Student(id, name, age,address);            
            students.Add(newStudent);
            Console.WriteLine("Record Added successfully");
        }

        public static void DisplayAll()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void FindStudent()
        {
            Console.WriteLine("Enter Student Id : ");
            int inputId = int.Parse(Console.ReadLine());
            foreach (Student student in students)
            {
                if (student.StudentId==inputId)
                {
                    Console.WriteLine(student);
                }
            }
        }

        public static void UpdateStudent()
        {
            Console.WriteLine("Enter Student Id : ");
            int inputId = int.Parse(Console.ReadLine());
            foreach (Student student in students)
            {
                if (student.StudentId == inputId)
                {
                    Console.WriteLine("Enter Updated Name : ");
                    string newName = Console.ReadLine();
                    student.StudentName = newName;
                    Console.WriteLine(student);
                }
            }
        }

        public static void RemoveStudent()
        {            
            Console.WriteLine("Enter Student Id : ");
            int inputId = int.Parse(Console.ReadLine());
            foreach (Student student in students.ToList())
            {
                if (student.StudentId == inputId)
                {
                    students.Remove(student);
                    Console.WriteLine("Record Removed Successfully!!");
                }
            }
        }

        public static void ClearAll()
        {
            Console.WriteLine("All Records Clear");
            students.Clear();
        }

        public static void DoTask()
        {            
            while (true)
            {
                Console.WriteLine("What do you wish to do ?\n" +
                    "1 . Add New Student Record\n" +
                    "2 . Display All Records\n" +
                    "3 . Find Student By ID\n" +
                    "4 . Update an Student Record\n" +
                    "5 . Remove Student By ID\n" +
                    "6 . Clear All\n" +                    
                    "7 . Exit\n");

                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayAll();
                        break;
                    case 3:
                        FindStudent();
                        break;
                    case 4:
                        UpdateStudent();
                        break;
                    case 5:
                        RemoveStudent();
                        break;
                    case 6:
                        ClearAll();
                        break;                    
                    case 7:                       
                        return;
                }
            }
        }

    }
}
