using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class ZerosEnd
    {
        public static void PrintZerosEnd()
        {
            int[] arr = { 1, 2, 5, 9, 0, 9, 0 };
            int len = arr.Length-1;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] == 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[len];
                    arr[len] = temp;
                    len--;
                }
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
            Console.WriteLine(arr[i]+" ");
            }


        }
    }
}
