using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class PerimeterAreaCircle
    {
        public static void CalculateCircle()
        {
            int radius=Convert.ToInt32(Console.ReadLine());
            int perimeter =Convert.ToInt32( 2 * 3.14 * radius);
            Console.WriteLine("Perimeter of the circle: " + perimeter);
            int area = Convert.ToInt32(3.14 * radius * radius);
            Console.WriteLine("Area of a circle : "+ area);
        }
    }
}
