using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class GradesOfStudent
    {
        public static void Grades()
        {
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("Grade C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("Grade D");
            }
            else if (score >= 0 && score < 60)
            {
                Console.WriteLine("Grade F");
            }  
        }
    }
}
