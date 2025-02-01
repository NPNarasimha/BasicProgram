using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class CheckingChars
    {
        public static void CheckChars()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            
            if (str.Contains("a") && str.Contains("e") && str.Contains("p"))
            {
                Console.WriteLine("All are Present");
            }
            else if(str.Contains("a") || str.Contains("e") || str.Contains("p"))
            {
                Console.WriteLine("One or more present");
            }
            else
            {
                Console.WriteLine("None is present");
            }

            /*
            char[] ch = str.ToCharArray();
            int count = 0;
            for (int i = 0; i <= ch.Length - 1; i++)
            {
            if(ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'p')
                {
                    count++;
                }
            }
                if (count==3)
                {
                    Console.WriteLine("All are Present");
                }
                else if (count > 1) 
                {
                    Console.WriteLine("One or more present");
                }
                else
                {
                    Console.WriteLine("None is present");
                }
           */

        }

    }
}
