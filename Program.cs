// See https://aka.ms/new-console-template for more information
using NewHomeWork;

var f1 = new Square(5, "зеленый");
Square f2 = new Square(2, "синий");
Square f3 = new Square(15, "голубой");

List<Square> squaresList = new List<Square>()
            {
                f1, f2, f3
            };
Console.WriteLine("Вывод 1");
foreach (var squares in squaresList)
{
    squares.AboutSqaure();
}
//просто добавила еще один объект
Square f4 = new Square(f1.sideLength*2, f2.color);
squaresList.Add(f4);

//Поменять длину стороны зеленого квадрата = длина стороны синего квадрата * 3
f1.ChangeSideLength(f1, f2.sideLength * 3);

Console.WriteLine("Вывод 2");
foreach (var squares in squaresList)
{
    squares.AboutSqaure();
}
