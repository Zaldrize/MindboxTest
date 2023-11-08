namespace Shapes
{
    public class Triangle : IShape
    {
        private double _a, _b, _c;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            if (!IsValid())
            {
                throw new Exception("That is not a valid triangle");
            }
        }
        private bool IsValid()
        {
            return _a > 0 && _b > 0 && _c > 0 && _a < _b + _c && _b < _a + _c && _c < _a + _b;
        }
        public bool IsRightTriangle()
        {
            double a2 = _a * _a;
            double b2 = _b * _b;
            double c2 = _c * _c;
            return a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2;
        }
        public double GetArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p*(p - _a)*(p - _b)*(p - _c));
        }
    }
}
