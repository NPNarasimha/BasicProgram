using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class ArrayPrimes
    {
        public static void Primes()
        {
            Console.WriteLine("Enter the prime Numbers");
            int [] arr=new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i =0;i<=arr.Length-1;i++)
            {
                int count = 0;
                for (int j = 2; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0) { 
                        count++;
                    }
                }
                if (count < 2)
                {
                    Console.WriteLine("Prime number is : " + arr[i]);

                }

            }

        }
    }
}
