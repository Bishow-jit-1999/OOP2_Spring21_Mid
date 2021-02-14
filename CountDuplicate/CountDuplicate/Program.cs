using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8 };
            int count=0;

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[0]== arr[i])
                {
                    count++;
                }
               

            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[1] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 3; i < arr.Length; i++)
            {
                if (arr[2] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 4; i < arr.Length; i++)
            {
                if (arr[3] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 5; i < arr.Length; i++)
            {
                if (arr[4] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 6; i < arr.Length; i++)
            {
                if (arr[5] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 7; i < arr.Length; i++)
            {
                if (arr[6] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 8; i < arr.Length; i++)
            {
                if (arr[7] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 9; i < arr.Length; i++)
            {
                if (arr[8] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 10; i < arr.Length; i++)
            {
                if (arr[9] == arr[i])
                {
                    count++;
                }


            }
            for (int i = 11; i < arr.Length; i++)
            {
                if (arr[10] == arr[i])
                {
                    count++;
                }


            }
            Console.WriteLine("Total number of duplicate number in array is: " + count);


        }
    }
}
