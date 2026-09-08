namespace CS1302.Lab06.Inheritance.Models;

public class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double @base, double height)
        : base("Triangle")
    {
        Base = @base;
        Height = height;
    }

    public double Area()
    {
        return 0.5 * Base * Height;
    }
}
