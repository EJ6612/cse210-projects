using System;

namespace Learning05 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Shape> shapes = new List<Shape>();
            Square square = new Square("blue", 4);
            Rectangle rectangle = new Rectangle("red", 4, 3);
            Circle circle = new Circle("yellow", 1);

            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The {shape.GetColor()} {shape.GetShapeName()} is {shape.GetArea()} units².\n");
            }

            Console.WriteLine("\n\n");

            
        }
    }
}