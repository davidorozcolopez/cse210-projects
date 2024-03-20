using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 2);
        // System.Console.WriteLine(square.GetArea());
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 2, 3);
        // System.Console.WriteLine(rectangle.GetArea());
        shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 10);
        // System.Console.WriteLine(circle.GetArea());
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            System.Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}