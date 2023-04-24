using System;

namespace Learning03
{
    class Fraction
    {
        private int _top, _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;

        }

        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;

        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;

        }

        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            double result = (double)_top / (double)_bottom;
            return result;
        }
    }
}