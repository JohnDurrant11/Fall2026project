using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>
        {
        new Square("orange", 4),
        new Rectangle("green", 7, 8),
        new Circle("yellow", 12),
        };

        foreach (Shape item in shapes)
        {
            Console.WriteLine($"Color: {item.GetColor()}; Area: {item.GetArea()};");
        }
    }
}