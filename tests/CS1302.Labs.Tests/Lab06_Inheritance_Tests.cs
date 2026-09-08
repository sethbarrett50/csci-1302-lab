using CS1302.Lab06.Inheritance.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab06_Inheritance_Tests
{
    [Fact]
    public void Circle_Area_Is_Correct()
    {
        Circle circle = new Circle(2.0);

        Assert.Equal(Math.PI * 4.0, circle.Area());
    }

    [Fact]
    public void Rectangle_Inherits_Name_From_Shape()
    {
        Rectangle rectangle = new Rectangle(3.0, 4.0);

        Assert.Equal("Rectangle", rectangle.Name);
        Assert.Equal(12.0, rectangle.Area());
    }

    [Fact]
    public void Triangle_Area_Is_Correct()
    {
        Triangle triangle = new Triangle(6.0, 2.0);

        Assert.Equal(6.0, triangle.Area());
    }
}
