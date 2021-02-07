using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=12;
            int b=24;
            Sample demo = new Sample();
            demo.ShowDetails();

            Console.WriteLine("int a={0} int b={1}", a, b);
        }
    }
}
