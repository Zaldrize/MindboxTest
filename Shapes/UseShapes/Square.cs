using Shapes;

namespace UseShapes
{
   // Client can add new shape via implementing an interface
    internal class Square : IShape
    {
        private double _side;
        public Square(double side)
        {
            if (side <= 0)
            {
                throw new Exception("That is an invalid square");
            }
            _side = side;
        }
        public double GetArea()
        {
            return _side*_side;
        }
    }
}
