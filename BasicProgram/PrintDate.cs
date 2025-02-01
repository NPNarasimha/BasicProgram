using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class PrintDate
    {
        public static void date()
        { Console.WriteLine("Enter the year: ");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month : ");
            int month=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day : ");
            int day=Convert.ToInt32(Console.ReadLine());
            if (month == 2)
            {
                if (year%400==0 ||year%4==0 &&year%100!=0&&day == 29)
                {
                    month++;
                    day = 1;
                }
                else if(year % 400 == 0 || year % 4 == 0 && year % 100 != 0 && day == 28)
                {
                    day += 1;
                }
                else
                {
                    day += 1;
                }
            }
            else if(month==12){
                if (day == 31)
                {
                    year++;
                    month = 1;
                    day = 1;
                }
                else
                {
                    day += 1;
                }
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
            {
                if (day == 31)
                {
                    month++;
                    day = 1;
                }
                else
                {
                    day += 1;
                }

            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 30)
                {
                    month++;
                    day = 1;
                }
                else
                {
                    day += 1;
                }

            }
            Console.WriteLine("Next date : "+year+": "+month+": "+day);
        }
    }
}
