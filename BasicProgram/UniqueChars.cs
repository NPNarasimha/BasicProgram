using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class UniqueChars
    {

        public static void uniqueChar()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string s = "";
            
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (!s.Contains(str[i]))
                {
                   s+= str[i];
                }
            }
            Console.WriteLine("The unique characters in the string are : " + s);
        }
    }
}
