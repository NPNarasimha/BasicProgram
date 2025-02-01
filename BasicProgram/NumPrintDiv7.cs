using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class NumPrintDiv7
    {
        public static void printDiv7()
        {
            int start = 2000;
            int end = 3200;
            for (int i = start; i <= end; i++)
            {
                if (i % 7 == 0 && i / 5 != 0)
                {
                    Console.Write(i + ", ");    
                }
            }

        }
    }
}
