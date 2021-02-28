using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueElementArray
{
    class Program

        
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 9, 10, 10 };

           

            for ( int i = 0; i < arr.Length; i++)
            {
                int count = 1;
               
                for(int j = i+1; j< arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        arr[j] = 0;
                    }

                    
                }
                if (arr[i]!=0)
                {
                    arr[i] = count;

                }




            }
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 1)
                {
                    Console.WriteLine(arr[i]);
                }
           }
        }

    }

}

          
           

            
