using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 300;
            bool Val = true;
            

            Console.WriteLine(b);
            Console.WriteLine(Val);
            Console.WriteLine("The value of int b is {0} and the bool Val is {1}", b, Val);
           
            byte x = 25;
            int y = x;
            Console.WriteLine("The Value of int y is {0}", y);

            byte a = (byte)b;
            Console.WriteLine("The Value of byte a is {0}", a);

            int v= 50000;
            short w = (short)v;
            Console.WriteLine("The Value of short w is {0}", w);

            double d = 5.77;
            float f = 5.77767f;
            Console.WriteLine("The Value of double d is {0} and the value of float f is {1}", d,f);




        }
    }
}
