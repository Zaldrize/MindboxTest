using Shapes;

namespace ShapesTest
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(1,1,2)]
        [InlineData(-1,2,3)]
        public void Triangle_InvalidSides_ThrowsException(double a, double b, double c)
        {
            var exception = Assert.Throws<Exception>(() => new Triangle(a, b, c));
            Assert.Equal("That is not a valid triangle", exception.Message);
        }

        [Fact]
        public void Triangle_Area_Test()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            Assert.Equal(6, area, 2);
        }

        [Theory]
        [InlineData(3,4,5)]
        [InlineData(4,5,3)]
        [InlineData(12, 5, 13)]
        public void Triangle_IsRight_ReturnsTrue(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isRight = triangle.IsRightTriangle();
            Assert.True(isRight);
        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(7,7,3)]
        public void Triangle_IsRight_ReturnsFalse(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isRight = triangle.IsRightTriangle();
            Assert.False(isRight);
        }
    }
}
