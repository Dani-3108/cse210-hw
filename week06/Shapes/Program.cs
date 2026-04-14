using System;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square testSquare = new Square("blue", 2);
        Console.WriteLine(testSquare.GetColor());
        Console.WriteLine(testSquare.GetArea());

        Rectangle testRectangle = new Rectangle("red", 2, 6);
        Console.WriteLine(testRectangle.GetColor());
        Console.WriteLine(testRectangle.GetArea());

        Circle testCircle = new Circle("yellow", 5);
        Console.WriteLine(testCircle.GetColor());
        Console.WriteLine(testCircle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(testSquare);
        shapes.Add(testRectangle);
        shapes.Add(testCircle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}