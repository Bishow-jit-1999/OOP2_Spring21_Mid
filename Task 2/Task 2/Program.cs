using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Evensum = 0;
            int Oddsum = 0;
            for(int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Evensum = Evensum + i;
                }
                else
                {
                    Oddsum = Oddsum + i;
                }
            }
            Console.WriteLine("The sum of the Even numbers are:" + Evensum);
            Console.WriteLine("The sum of the Odd numbers are:" + Oddsum);
        }
    }
}
