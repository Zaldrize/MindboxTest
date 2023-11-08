using Shapes;

namespace ShapesTest
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void Circle_ZeroOrNegativeRadius_ThrowsException(double rad)
        {
           var ex = Assert.Throws<Exception>(() => new Circle(rad));
            Assert.Equal("That is not valid radius", ex.Message);
        }

        [Fact]
        public void Circle_Radius_CheckArea()
        {
            var circle = new Circle(3);
            var area = circle.GetArea();
            Assert.Equal(28.2743, area, 4);
        }
    }
}
