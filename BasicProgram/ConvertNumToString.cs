using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class ConvertNumToString
    {
        public static void NumToString()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 && num % 5 != 0 && num % 7 != 0)
            {
                Console.WriteLine("Pling");
            }
            else if (num % 3 != 0 && num % 5 == 0 && num % 7 != 0)
            {
                Console.WriteLine("Plang");
            }
            else if (num % 3 != 0 && num % 5 != 0 && num % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else if (num % 3 == 0 && num % 5 == 0 && num % 7 != 0)
            {
                Console.WriteLine("PlingPlang");
            }
            else if (num % 3 == 0 && num % 5 != 0 && num % 7 == 0)
            {
                Console.WriteLine("PlingPlong");

            }
            else if (num % 3 != 0 && num % 5 != 0 && num % 7 == 0)
            {
                Console.WriteLine("PlangPlong");
            }
            else if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("PlingPlangPlong");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
