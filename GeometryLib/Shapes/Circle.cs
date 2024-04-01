namespace GeometryLib.Shapes;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius) : base(() => Math.PI * radius * radius)
    {
        if (radius <= 0 || double.IsNaN(radius) || double.IsInfinity(radius) || radius == double.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius should be a positive number and can't be NaN or Infinity!");

        Radius = radius;
    }

}