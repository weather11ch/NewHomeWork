using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Circle : Shape
    {

        public Circle(int lengthParameter1) : base(lengthParameter1)
        {
        }
        public static void CirclePerimeter(int lengthParameter1, int lengthParameter2, out double circlePerimeter)
        {
            circlePerimeter = 2 * Math.PI * lengthParameter1 ;
            Console.WriteLine($" длина окружности {circlePerimeter}");
            return;
        }
        public static void CircleArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double circleArea)
        {
            circleArea = Math.PI * lengthParameter1 * lengthParameter1;
            Console.WriteLine($" площадь круга {circleArea}");
            return;
        }
    }    
}
