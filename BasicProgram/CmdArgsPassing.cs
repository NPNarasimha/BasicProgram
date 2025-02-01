using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class CmdArgsPassing
    {
        public static void CmdArgs(string[] args) 
        {
            int count = 0;
            string str= "";
            for (int i = 0; i < args.Length; i++)
            {
                count++;
                str += args[i]+" ";
            }
            Console.WriteLine(count);
            Console.WriteLine(str);
        }
    }
}
