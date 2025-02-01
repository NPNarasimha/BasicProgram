using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BasicProgram
{
    internal class PrintNum
    {
        public static void Numbers()
        {
            Console.WriteLine("Enter the number");
            String num = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
            }
        }
    }
}
