using System;

namespace GeometryLib.Shapes
{
    public class Triangle : Figure
    {
        private readonly double[] _triangleSides;

        public Triangle(double a, double b, double c) : base(() =>
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        })
        {
            if (!IsValidSide(a) || !IsValidSide(b) || !IsValidSide(c))
                throw new ArgumentOutOfRangeException("Invalid side length.");

            if (!IsTriangleValid(a, b, c))
                throw new ArgumentException("Invalid sides lengths for a triangle.");

            _triangleSides = new[] { a, b, c };
        }

        private static bool IsValidSide(double side)
        {
            return side > 0 && !double.IsNaN(side) && !double.IsInfinity(side);
        }

        private static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }

        public bool IsRight()
        {
            const double possibleError = 1e-4;

            Array.Sort(_triangleSides);

            var a = _triangleSides[0];
            var b = _triangleSides[1];
            var c = _triangleSides[2];

            return Math.Abs(a * a + b * b - c * c) <= possibleError;
        }
    }
}
