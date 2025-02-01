using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class Upper_LowerCase
    {
        public static void PrintPlace() {
        String place=Console.ReadLine(); 
            Console.WriteLine("UPPER CASE : "+place.ToUpper());
            Console.WriteLine("lower case : "+place.ToLower());
        }
    }
}
