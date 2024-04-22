// See https://aka.ms/new-console-template for more information
using NewHomeWork;

Console.WriteLine("");

Shape[] figure = new Shape[5];
figure[0] = new Triangle(2, 4, 1);
figure[1] = new Rectangle(2, 4);
figure[2] = new Circle(4);
figure[3] = new Shape(2, 4, 1);
figure[4] = new Triangle(2, 4, 1);


int[] per = new int[5];


figure[1].RectanglePerimeter(figure[1].lengthParameter1, figure[1].lengthParameter2,out per[0]);
