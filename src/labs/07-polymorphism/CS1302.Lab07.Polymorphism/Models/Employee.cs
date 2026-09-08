namespace CS1302.Lab07.Polymorphism.Models;

public class Employee
{
    public string Name { get; }

    public Employee(string name)
    {
        Name = name;
    }

    public virtual decimal CalculatePay()
    {
        return 0m;
    }
}
