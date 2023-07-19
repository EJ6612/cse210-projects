namespace Learning05
{
    public class Rectangle : Shape
    {
        private double _length, _width;

        public Rectangle(string color, double length, double width) : base(color)
        {
            _length = length;
            _width = width;
            SetColor(color);
            SetShapeName("rectangle");
        }

        public override double GetArea()
        {
            return _length * _width;
        }
        
    }
}