namespace GeometryLib.Shapes;
public class Square : Figure
{
    public double Side { get; }

    public Square(double side) : base(() => side * side)
    {
        if (!IsValidSide(side))
            throw new ArgumentOutOfRangeException(nameof(side), "Square side has to be a positive number and can't be NaN or Infinity!");

        Side = side;
    }

    private static bool IsValidSide(double side)
    {
        return side > 0 && !double.IsNaN(side) && !double.IsInfinity(side) && side != double.MaxValue;
    }
}
