using GeometryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibTests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_Calculate_Area_Works()
        {
            //Arrange
            double SideA = 5.0;
            double SideB = 5.0;
            double SideC = 7.5;
            double Surface = (SideA + SideB + SideC) / 2;
            var triangle = new Triangle(SideA, SideB, SideC);
            
            //Act
            var triangleArea = triangle.CalculateArea();

            //Assert
            Assert.Equal(triangleArea, Math.Sqrt(Surface * (Surface - SideA) * (Surface - SideB) * (Surface - SideC)));
        }

        [Fact]
        public void Triangle_Is_Right_Triangle_Works()
        {
            //Arrange
            double SideA = 5.0;
            double SideB = 5.0;
            double SideC = 7.5;
            var triangle = new Triangle(SideA, SideB, SideC);

            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            var TriangleRight = (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2]);

            //Act
            var IsRightTriangle = triangle.IsRightTriangle();

            //Assert
            Assert.Equal(TriangleRight, IsRightTriangle);
        }

    }
}
