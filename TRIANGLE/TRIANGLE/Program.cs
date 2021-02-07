using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGLE
{
    class Triangle

    {
        private int x;
        private int y;
        private int z;

        private Triangle()
        {

        }
        private Triangle(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private void ShowInfo()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            if (x==y || x==z )           
            {
                Console.WriteLine("Triangle is isosceles");
            }
              
           
            else
            {
                Console.WriteLine("Triangle is scalene");
            }
        }
        static void Main(string[] args)
        {
            Triangle t = new Triangle(1, 2, 2);

            t.ShowInfo();
        }
    }
}
