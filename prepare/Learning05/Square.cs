using System;

namespace Learning05
{
    public class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base(color)
        {
            SetColor(color);
            _side = side;
            SetShapeName("square");
        }

        public override double GetArea()
        {
            return _side * _side;
        }

    }
}