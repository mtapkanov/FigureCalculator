using System;
using Solution.Figures;
using Solution.Parameters;
using Xunit;

namespace FigureCalculator
{
    public class FigureCalculatorTests
    {
        [Fact]
        public void ItShouldBeCalculateCircleSquare()
        {
            const double expectedValue = 19.634954084936208;

            var parameter = new CircleParameter(2.5);
            var sut = new Circle(parameter);
            var result = sut.OnCalculate();

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ItShouldBeCalculateRectangleSquare()
        {
            const double expectedValue = 25;

            var parameter = new RectangleParameter(5, 5);
            var sut = new Rectangle(parameter);
            var result = sut.OnCalculate();

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ItShouldBeCalculateTriangleSquare()
        {
            const double expectedValue = 9.9215674164922145;

            var parameter = new TriangleParameter(4, 5, 6);
            var sut = new Triangle(parameter);
            var result = sut.OnCalculate();

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void ItShouldBeRightTriangle()
        {
            const double expectedValue = 6;

            var parameter = new TriangleParameter(4, 5, 3);
            var sut = new Triangle(parameter);
            var result = sut.OnCalculate();
            var isRight = sut.IsRight;

            Assert.Equal(expectedValue, result);
            Assert.True(isRight);
        }

        [Fact]
        public void ItShouldBeThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var parameter = new CircleParameter(25);
                var sut = new Triangle(parameter);
                sut.OnCalculate();
            });
        }

        [Fact]
        public void ItShouldBeCalculateByUnknownFigure()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var parameter = new CircleParameter(25);
                var sut = new Triangle(parameter);
                sut.OnCalculate();
            });
        }
    }
}