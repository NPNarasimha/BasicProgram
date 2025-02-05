using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class AvgArrayNum
    {
        public static void Avg()
        {
            Console.WriteLine("Enetr zize of an array");
            float[] arr = new float[Convert.ToInt32(Console.ReadLine())];
            float sum = 0;
            for(int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i]=float.Parse(Console.ReadLine());
                sum += arr[i];
            }

            float avgArr= sum / arr.Length;
            Console.WriteLine("Avarage the array : " + avgArr);
        }
    }
}
