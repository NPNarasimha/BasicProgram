using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class PrintNames
    {

        public static void Names()
        {
            Console.WriteLine("Enter the 5 friends Names");
            String name1 = Console.ReadLine();
            String name2 = Console.ReadLine();
            String name3 = Console.ReadLine();
            String name4 = Console.ReadLine();
            String name5 = Console.ReadLine();
            Console.WriteLine("Friend Name1 : " + name1);
            Console.WriteLine("Friend Name2 : " + name2);
            Console.WriteLine("Friend Name3 : " + name3);
            Console.WriteLine("Friend Name4 : " + name4);
            Console.WriteLine("Friend Name5 : " + name5);

        }
    }
}
    