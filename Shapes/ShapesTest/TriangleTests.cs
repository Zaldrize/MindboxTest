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
    }
}
