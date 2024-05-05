// See https://aka.ms/new-console-template for more information
using NewHomeWork;

Console.WriteLine("");

Shape[] figure = new Shape[5];
figure[0] = new Triangle(2, 4, 1);
figure[1] = new Rectangle(2, 4);
figure[2] = new Circle(4);
figure[3] = new Shape(2, 4, 1);
figure[4] = new Triangle(2, 4, 1);


double[] per = new double[5];
double[] area = new double[5];

figure[1].RectanglePerimeter(figure[1].lengthParameter1, figure[1].lengthParameter2,out per[1]);
figure[1].RectangleArea(figure[1].lengthParameter1, figure[1].lengthParameter2, figure[1].lengthParameter3,out area[1]);

figure[0].TrianglePerimeter(figure[0].lengthParameter1, figure[0].lengthParameter2, figure[0].lengthParameter3,out per[0]);
figure[0].TriangleArea(figure[0].lengthParameter1, figure[0].lengthParameter2, figure[0].lengthParameter3, out area[0]);

figure[2].CirclePerimeter(figure[2].lengthParameter1,out per[2]);
figure[2].CircleArea(figure[2].lengthParameter1, out area[2]);

figure[3].TrianglePerimeter(figure[3].lengthParameter1, figure[3].lengthParameter2, figure[3].lengthParameter3, out per[3]);
figure[3].TriangleArea(figure[3].lengthParameter1, figure[3].lengthParameter2, figure[3].lengthParameter3, out area[3]);

figure[4].TrianglePerimeter(figure[4].lengthParameter1, figure[4].lengthParameter2, figure[4].lengthParameter3, out per[4]);
figure[4].TriangleArea(figure[4].lengthParameter1, figure[4].lengthParameter2, figure[4].lengthParameter3, out area[4]);

double perimetrSum = 0;
for (int i = 0;i<5;i++)
{
    perimetrSum += per[i];
}
Console.WriteLine($"сумма периметров равна {perimetrSum}");
