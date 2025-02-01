using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class PrintNumInRecursion
    {
        public static void PrintNumRecursion(int n)
        {
            
            if (n > 100)
            {
                return ;
            }
            else
            {
                Console.Write(n+" ");
                PrintNumRecursion(n+1);
            }

        }
       
    }
}
