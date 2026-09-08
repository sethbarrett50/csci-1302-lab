using CS1302.Lab06.Inheritance.Models;

namespace CS1302.Lab06.Inheritance;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Inheritance Practice ==");

        Console.WriteLine();
        Circle circle = new Circle(3.0);
        circle.Describe();
        Console.WriteLine($"Area: {circle.Area():F2}");

        Console.WriteLine();
        Rectangle rectangle = new Rectangle(4.0, 5.0);
        rectangle.Describe();
        Console.WriteLine($"Area: {rectangle.Area():F2}");

        Console.WriteLine();
        Triangle triangle = new Triangle(6.0, 2.0);
        triangle.Describe();
        Console.WriteLine($"Area: {triangle.Area():F2}");
    }
}
