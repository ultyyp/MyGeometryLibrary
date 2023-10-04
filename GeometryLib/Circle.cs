namespace GeometryLib
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}