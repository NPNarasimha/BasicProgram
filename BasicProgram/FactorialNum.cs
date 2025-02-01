using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class FactorialNum
    {
        public static void factorial()
        {   Console.WriteLine("Enter a number to find factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;

            }
            Console.WriteLine("Factorial of a number is : "+ fact);
        }
    }
}
