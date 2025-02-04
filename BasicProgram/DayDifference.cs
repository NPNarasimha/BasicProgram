using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class DayDifference
    {
        public static void daysCal()
        {
            Console.WriteLine("Enter the first date in the format dd/mm/yyyy");
            string date1 = Console.ReadLine();
            Console.WriteLine("Enter the second date in the format dd/mm/yyyy");
            string date2 = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(date1);
            DateTime dt2 = Convert.ToDateTime(date2);
            TimeSpan ts = dt2 - dt1;
            Console.WriteLine("Difference between the two dates is: " + ts.Days + " days");
        }
    }
}
