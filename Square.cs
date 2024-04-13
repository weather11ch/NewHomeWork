using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Square
    {
        public String color;
        public int sideLength;
        public int squareArea;
        public Square(int a, String color)
        {
            this.sideLength = a;
            this.color = color;
            squareArea = a * a;
        }
        public void AboutSqaure()
        {
            Console.WriteLine($"{color}  квадрат со стороной {sideLength}  и площадью  {squareArea}") ;
        }
    }
}
