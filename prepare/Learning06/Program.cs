using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(new Square("blue", 4));
        _shapes.Add(new Rectangle("white", 10, 3));
        _shapes.Add(new Circle("purple", 8));

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine("");
        }
        // Square square = new Square("red", 2);
        // square.SetColor("red");
        // Console.WriteLine($"Color: {square.GetColor()}");
        // Console.WriteLine($"Area: {square.GetArea()}");

        // Console.WriteLine("");

        // Rectangle rectangle = new Rectangle("green", 4, 6);
        // rectangle.SetColor("green");
        // Console.WriteLine($"Color: {rectangle.GetColor()}");
        // Console.WriteLine($"Area: {rectangle.GetArea()}");

        // Console.WriteLine("");

        // Circle circle = new Circle("yellow", 5);
        // circle.SetColor("yellow");
        // Console.WriteLine($"Color: {circle.GetColor()}");
        // Console.WriteLine($"Area: {circle.GetArea()}");

    }
}