using GeometryLib;

namespace GeometryLibTests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_Calculate_Area_Works()
        {
            //Arrange
            double radius = 5.0;
            var circle = new Circle(radius);

            //Act
            var circleArea = circle.CalculateArea();

            //Assert
            Assert.Equal(circleArea, Math.PI * radius * radius);
        }
    }
}