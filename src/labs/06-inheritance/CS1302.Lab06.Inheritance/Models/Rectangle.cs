namespace CS1302.Lab06.Inheritance.Models;

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
        : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }
}
