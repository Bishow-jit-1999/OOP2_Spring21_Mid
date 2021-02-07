using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Phy = 89;
            int Chem = 85;
            int Bio = 79;
            int Math = 70;
            int Comp = 88;
            int ExamTotal = 500;

            int Total = Phy + Chem + Bio + Math + Comp;
            double Percentage = (Total * 100) / ExamTotal;
            Console.WriteLine("Student gained percentahe:" + Percentage);

            if (Percentage >= 90)
            {
                Console.WriteLine("The Studet grade is:A+");

            }
            if (Percentage < 90 && Percentage >= 85)
            {
                Console.WriteLine("The Studet grade is:A");
            }
            if (Percentage < 85 && Percentage >= 80)
            {

                Console.WriteLine("The Studet grade is:B+");
            }
            if (Percentage < 80 && Percentage >= 75)
            {
                Console.WriteLine("The Studet grade is:B");
            }
            if (Percentage < 75 && Percentage >= 50)
            {
                Console.WriteLine("The Studet grade is:C+");
            }
            if (Percentage < 50)
            {
                Console.WriteLine(" Studet grade is:F");
            }
        }
    }
}
