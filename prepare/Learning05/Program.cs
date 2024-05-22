using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("yellow", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("red", 4, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("blue", 4);
        shapes.Add(circle);

        //Console.WriteLine($"The square is {square.GetColor()} and the area is {square.GetArea()}");
        //Console.WriteLine($"The rectangle is {rectangle.GetColor()} and the area is {rectangle.GetArea()}");
        //Console.WriteLine($"The squre is {circle.GetColor()} and the area is {circle.GetArea()}");
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}