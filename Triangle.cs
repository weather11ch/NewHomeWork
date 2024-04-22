using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Triangle : Shape
    {

        public Triangle(int lengthParameter1, int lengthParameter2, int lengthParameter3) : base(lengthParameter1, lengthParameter2, lengthParameter3)
        {
        }
        public static void TrianglePerimeter(int lengthParameter1, int lengthParameter2, int lengthParameter3, out int trianglePerimeter)
        {
            trianglePerimeter = lengthParameter1 + lengthParameter2 + lengthParameter3;
            Console.WriteLine($" периметр треугольника {trianglePerimeter}");
            return;
        }
        public static void TriangleArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double triangleArea)
        {
            triangleArea = (lengthParameter1 * lengthParameter1 * Math.Sqrt(3)) / 2;
            Console.WriteLine($" площадь треугольника {triangleArea}");
            return;
        }
    }
}
