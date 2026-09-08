namespace CS1302.Lab06.Inheritance.Models;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
        : base("Circle")
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
