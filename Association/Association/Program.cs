using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Bishowjit", "18-38250-2", 3.76f);
            Student S2 = new Student("Rahim", "18-38000-1", 3.80f);
            Student S3 = new Student("Ron", "19-30000-3", 2.8f);
            Department D1 = new Department("Computer Science Engineering", "CSE");
            //Department D2 = new Department("Software Engineering", "SE");
            // S1.Dept=D1 ;
            // S2.Dept = D2;
            D1.AddStudent(S1,S2,S3);
            
            

        }
    }
}
