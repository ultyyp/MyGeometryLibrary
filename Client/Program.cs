using GeometryLib;
using System.ComponentModel.DataAnnotations;

double CalculateAreaOfFigure(IFigure figure)
{
    return figure.CalculateArea();
}

IFigure circle = new Circle(5.0);
IFigure triangle = new Triangle(3.0, 4.0, 5.0);

double circleArea = CalculateAreaOfFigure(circle);
double triangleArea = CalculateAreaOfFigure(triangle);

Console.WriteLine($"Площадь круга: {circleArea}");
Console.WriteLine($"Площадь треугольника: {triangleArea}");

if (triangle is Triangle triangleObj)
{
    if (triangleObj.IsRightTriangle())
    {
        Console.WriteLine("Этот треугольник является прямоугольным.");
    }
    else
    {
        Console.WriteLine("Этот треугольник не является прямоугольным.");
    }
}
