using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        
        Rectangle rectangle = new Rectangle("Blue", 4, 7);
        shapes.Add(rectangle);

        Square square = new Square("Red", 7);
        shapes.Add(square);

        Circle circle = new Circle("Green", 7);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string colour = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {colour} shape has an area of {area}");
        }
    }
}