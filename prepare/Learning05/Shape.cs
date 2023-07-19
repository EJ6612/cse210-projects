namespace Learning05
{
    public abstract class Shape
    {
        private string _color, _name;

        public Shape(string color)
        {
            SetColor(color);
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetShapeName(string name)
        {
            _name = name;
        }

        public string GetShapeName()
        {
            return _name;
        }

        public abstract double GetArea();
    }
}