using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class TemparatureCal
    {
        public static void Temparature()
        {
            Console.WriteLine("Enter the temparature");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 1 to calculate in celsius and 2 for calculate in Fahrenheit");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1) { 
            double celsius = (temp - 32) * 5 / 9;
                Console.WriteLine("The Temparature in Celsius : " + celsius);
            }
            else if (userChoice == 2)
            {
                double fahrenheit = (temp * 9 / 5) + 32;
                Console.WriteLine("The Temparature in Fahrenheit : " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            
        }
    }
}
