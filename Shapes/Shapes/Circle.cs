namespace Shapes
{
    public class Circle: IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("That is not valid radius");
            }
            _radius = radius;

        }
        public double GetArea()
        {
           return Math.PI * _radius * _radius;
        }
    }
}
