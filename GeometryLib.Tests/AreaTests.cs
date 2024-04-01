using FluentAssertions;
using GeometryLib;
using GeometryLib.Shapes;
using Xunit;

namespace GeometryLib.Tests
{
    public class AreaTests
    {
        // Circle

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Circle_Area_Calculated(double radius)
        {
            // Arrange
            var expectedArea = Math.PI * radius * radius;

            // Act
            var circle = new Circle(radius);

            // Assert
            circle.Area.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NaN)]
        public void Circle_Area_Not_Calculated_With_Bad_Radius(double radius)
        {
            // Arrange, Act & Assert
            FluentActions.Invoking(() => new Circle(radius))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }

        // Triangle

        [Theory]
        [InlineData(3, 4, 5)]
        public void Triangle_Area_Calculated_And_Checked_For_Right(double a, double b, double c)
        {
            // Arrange
            var p = (a + b + c) / 2;
            var expectedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Act
            var triangle = new Triangle(a, b, c);

            // Assert
            triangle.Area.Should().Be(expectedArea);
            triangle.IsRight().Should().BeTrue();
        }

        [Theory]
        [InlineData(3, 4, 10)]
        [InlineData(16, 1, 2)]
        public void Triangle_Area_Not_Calculated_With_Exception(double a, double b, double c)
        {
            // Arrange, Act & Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .ThrowExactly<ArgumentException>();
        }

        [Theory]
        [InlineData(5, 4, 5)]
        public void Triangle_Area_Calculated_And_Checked_For_Right_With_False(double a, double b, double c)
        {
            // Arrange
            var p = (a + b + c) / 2;
            var expectedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Act
            var triangle = new Triangle(a, b, c);

            // Assert
            triangle.Area.Should().Be(expectedArea);
            triangle.IsRight().Should().BeFalse();
        }

        [Theory]
        [InlineData(double.PositiveInfinity, 4, 5)]
        [InlineData(3, double.PositiveInfinity, 5)]
        [InlineData(3, 4, double.PositiveInfinity)]
        public void Triangle_Not_Created_With_Infinity_Side(double a, double b, double c)
        {
            // Arrange, Act & Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }

        // Square

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Square_Area_Calculated(double side)
        {
            // Arrange
            var expectedArea = side * side;

            // Act
            var square = new Square(side);

            // Assert
            square.Area.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(double.MaxValue)]
        [InlineData(double.NaN)]
        [InlineData(-5)]
        public void Square_Area_Not_Calculated_With_Bad_Side(double side)
        {
            // Arrange, Act & Assert
            FluentActions.Invoking(() => new Square(side))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }
    }
}
