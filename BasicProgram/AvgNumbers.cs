using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class AvgNumbers
    {
        public static void AverageNums()
        {
            int sum=0;
            String nums = "";
            Console.WriteLine("Enter the numbers between 10 to 50");
            for (int i = 1; i <= 5; i++)
            {  
                
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 10 && num <= 50)
                {
                    nums += num + " ";
                    sum += num;
                }
                else
                {
                    i--;
                }
            }
            float avg = sum / 5;
            Console.WriteLine(nums);
            Console.WriteLine("The Average of Numbers : "+avg);
        }
    }
}
