using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class SumDiffSqrt
    {
        public static void SumDiff() {
            Console.WriteLine("Enter the two Numbers ");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Double num2 = Convert.ToDouble(Console.ReadLine());
            Double sumRes=num1+ num2;
            Console.WriteLine("Squert of Sum two Number : "+Math.Sqrt(sumRes));
            Double diffRes;
            if (num1 >=num2)
            {
                 diffRes = num1 - num2;
            }
            else
            {
                 diffRes = num2- num1;
            }
            Console.WriteLine("Squert of difference two Number : "+Math.Sqrt(diffRes));
        }
    }
}
