using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class Anagrams
    {
        public static void anagram()
        {
            Console.WriteLine("Enter the first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string s1 = new string(ch1);
            string s2 = new string(ch2);
            if (s1.Equals(s2))
            {
                Console.WriteLine("The given string are anagrams");
            }
            else
            {
                Console.WriteLine("The given string are not anagrams");

            }
        }
    }
}
