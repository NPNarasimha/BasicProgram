using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class AgeCalculate
    {
        public static void ageCal()
        {
            Console.WriteLine("Enter your date of birth in the format dd/mm/yyyy");
            string dob = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(dob);
            DateTime dt2 = DateTime.Now;
            TimeSpan ts = dt2 - dt1;
            Console.WriteLine("Your age is: " + ts.Days / 365 + " years");
        }
    }
}
