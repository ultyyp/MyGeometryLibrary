using System;

namespace GeometryLib.Shapes
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        public double Area => _area.Value;

        protected Figure(Func<double> areaCalculator)
        {
            _area = new Lazy<double>(areaCalculator);
        }
    }
}
