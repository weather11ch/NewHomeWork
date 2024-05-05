using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class Shape
    {
        public int lengthParameter1;
        public int lengthParameter2;
        public int lengthParameter3;
        public Shape(int lengthParameter1) 
        { 
            this.lengthParameter1 = lengthParameter1;
        }
        public Shape(int lengthParameter1, int lengthParameter2)
        {
            this.lengthParameter1 = lengthParameter1;
            this.lengthParameter2 = lengthParameter2;
        }
        public Shape(int lengthParameter1, int lengthParameter2, int lengthParameter3)
        {
            this.lengthParameter1 = lengthParameter1;
            this.lengthParameter2 = lengthParameter2;
            this.lengthParameter3 = lengthParameter3;
        }
        //
        //public void ShapePerimeter(string shapeType, Shape(int lengthParameter1, int lengthParameter2, int lengthParameter3), out double perimeter)
        //{
        //    if (shapeType == 'triangle') { RectanglePerimeter(Shape.); }
        //    return perimeter;
        //}
        //public void ShapeArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double rectangleArea)
        //{
        //    rectangleArea = lengthParameter1 * lengthParameter2;
        //    Console.WriteLine($" площадь прямоугольника {rectangleArea}");
        //}
        //
        public void RectanglePerimeter(int lengthParameter1, int lengthParameter2, out double rectanglePerimeter)
        {
            rectanglePerimeter = 2 * (lengthParameter1 + lengthParameter2);
            Console.WriteLine($" периметр прямоугольника {rectanglePerimeter}");
            return;
        }
        public void RectangleArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double rectangleArea)
        {
            rectangleArea = lengthParameter1 * lengthParameter2;
            Console.WriteLine($" площадь прямоугольника {rectangleArea}");
        }
        public void TrianglePerimeter(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double trianglePerimeter)
        {
            trianglePerimeter = lengthParameter1 + lengthParameter2 + lengthParameter3;
            Console.WriteLine($" периметр треугольника {trianglePerimeter}");
            return;
        }
        public void TriangleArea(int lengthParameter1, int lengthParameter2, int lengthParameter3, out double triangleArea)
        {
            triangleArea = (lengthParameter1 * lengthParameter1 * Math.Sqrt(3)) / 2;
            Console.WriteLine($" площадь треугольника {triangleArea}");
            return;
        }
        public void CirclePerimeter(int lengthParameter1, out double circlePerimeter)
        {
            circlePerimeter = 2 * Math.PI * lengthParameter1;
            Console.WriteLine($" длина окружности {circlePerimeter}");
            return;
        }
        public void CircleArea(int lengthParameter1, out double circleArea)
        {
            circleArea = Math.PI * lengthParameter1 * lengthParameter1;
            Console.WriteLine($" площадь круга {circleArea}");
            return;
        }
    }
}
