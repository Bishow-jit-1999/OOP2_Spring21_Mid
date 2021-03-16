using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] arg)
        {
            
            Student S1 = new Student("Bishowjit", "18-38250-2", 3.76f);
            Student S2 = new Student("Rahim", "18-38000-1", 3.80f);
            Student S3 = new Student("Ron", "19-30000-3", 2.8f);
            Student S4 = new Student("Rubayet", "16-38255-2", 3.5f);
            Department D1 = new Department("Computer Science Engineering", "CSE");
            Department D2 = new Department("Electrical and Eletronic Engineerimg", "EEE");
            Department D3 = new Department("Software Engineering", "SE");


            D1.AddStudent(S1,S2);
            D1.AllStudent();

            Console.WriteLine("******************************");
            D2.AddStudent(S3);
            D2.AllStudent();


            Console.WriteLine("******************************");
            D3.AddStudent(S4);
            D3.AllStudent();





        }
    }
}
