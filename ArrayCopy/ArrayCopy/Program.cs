using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[] { 25, 35, 45, 55, 65, 75 ,85};
            Console.WriteLine("Element in arr1 are:");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]+" ");
            }
             

            int[] arr2 = new int[arr1.Length];
            Console.WriteLine("Element in arr2 are:");

            for (int i=0;i<arr1.Length;i++)
            {
                arr2[i] = arr1[i];
                Console.WriteLine(arr2[i]+" ");
            }

        }
    }
}
