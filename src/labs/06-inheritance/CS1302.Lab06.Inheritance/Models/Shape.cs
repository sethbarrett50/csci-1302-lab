namespace CS1302.Lab06.Inheritance.Models;

public class Shape
{
    public string Name { get; }

    public Shape(string name)
    {
        Name = name;
    }

    public void Describe()
    {
        Console.WriteLine($"This shape is a {Name}.");
    }
}
