using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class DaysCal
    {
        public static void daysCalculate()
        {
            Console.WriteLine("Enter the first date in the format dd/mm/yyyy");
            string dob = Console.ReadLine();
            DateTime date = Convert.ToDateTime(dob);
            DateTime present= DateTime.Now;
            TimeSpan t=date-present;
            Console.WriteLine("The difference between the two dates is: " + t.Days + " days");

        }
    }
}
