using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        
        List<Shape> shapes = new List<Shape>
        {
            new Square("green", 2.5),
            new Rectangle("yellow", 2.5, 5.5),
            new Circle("red", 2)
        };
        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}