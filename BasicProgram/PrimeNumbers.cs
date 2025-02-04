using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class PrimeNumbers
    {
        public static void Primes()
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count < 2)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
