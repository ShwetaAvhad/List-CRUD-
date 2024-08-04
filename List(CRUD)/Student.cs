using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_CRUD_
{
    public class Student
    {
        public int StudentId {  get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentAddress { get; set; }

        public Student(int id,string name, int age,string address)
        {
            StudentId = id;
            StudentName = name;
            StudentAge = age;
            StudentAddress = address;
        }

        public override string ToString()
        {
            return $"Student ID : {StudentId}\n" +
                $"Student Name : {StudentName}\n" +
                $"Student Age : {StudentAge}\n" +
                $"Student Address : {StudentAddress}\n";
        }

    }
}
