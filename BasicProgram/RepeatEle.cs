using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class RepeatEle
    { 
        public static void RepeatElement()
        {
            int[] arr = { 1, 2, 3, 0, 7, 3, 21, 1, 3, 4, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("First Repeat Element : " + arr[i]);
                        return;
                    }
                }
            }
        }
    }
}
