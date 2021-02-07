using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {

        String Name = "Bishowjit Saha";
        String Id = "18-28350-2";
        String Department = "CSE";
        float Cgpa = 3.75f;

        public  Student(String Name, String Id, String Department, float Cgpa)
        {
            this.Name = Name;
            this.Id = Id;
            this.Department = Department;
            this.Cgpa = Cgpa;
        }

        public Student()
        {
        }


        public void ShowInfo()
        {
            Console.WriteLine("Student name:" + Name);
            Console.WriteLine("Student id:" + Id);
            Console.WriteLine("Student Department:" + Department);
            Console.WriteLine("Student cgpa:" + Cgpa);
        }


        static void Main(string[] args)
        {

           
            Student S1 = new Student();
            S1.ShowInfo();

        }
    }
}
