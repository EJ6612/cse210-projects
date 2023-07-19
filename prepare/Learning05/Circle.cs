namespace Learning05
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
            SetColor(color);
            SetShapeName("circle");
        }

        public override double GetArea()
        {
            return (double)Math.PI * (_radius * _radius);
        }

        
    }
}