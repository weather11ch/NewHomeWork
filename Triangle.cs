using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Triangle : Shape
    {
        public int lengthSide1;
        public int lengthSide2;
        public int lengthSide3;

        public Triangle(int lengthParameter1, int lengthParameter2, int lengthParameter3) : base (lengthParameter1,  lengthParameter2, lengthParameter3) 
        {
        }
        public static void TrianglePerimeter(int lengthParameter1, int lengthParameter2, int lengthParameter3)
        {
            int trianglePerimeter = lengthParameter1 + lengthParameter2 + lengthParameter3;
            Console.WriteLine($" периметр треугольника {trianglePerimeter}");
        }
    }
}
