using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("black", 20));
        shapes.Add(new Rectangle("white", 20, 10));
        shapes.Add(new Circle("blue", 20));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
        
    }
}