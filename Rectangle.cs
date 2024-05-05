using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Rectangle : Shape
    {

        public Rectangle(int lengthParameter1, int lengthParameter2) : base(lengthParameter1, lengthParameter2)
        {
        }
        public static void RectanglePerimeter(int lengthParameter1, int lengthParameter2, out double rectanglePerimeter)
        {
            rectanglePerimeter = 2*(lengthParameter1 + lengthParameter2) ;
            Console.WriteLine($" периметр прямоугольника {rectanglePerimeter}");
            return;
        }
        public static void RectangleArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double rectangleArea)
        {
            rectangleArea = lengthParameter1 * lengthParameter2;
            Console.WriteLine($" площадь прямоугольника {rectangleArea}");
        }
    
    }
}
