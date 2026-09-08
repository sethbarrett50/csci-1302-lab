using CS1302.Lab07.Polymorphism.Models;

namespace CS1302.Lab07.Polymorphism;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Polymorphism Practice ==");
        Console.WriteLine();

        List<Employee> employees = new List<Employee>
        {
            new HourlyEmployee("Alex", 20m, 80.0),
            new SalariedEmployee("Bailey", 62400m),
            new CommissionEmployee("Casey", 500m, 4000m, 0.05m),
        };

        decimal totalPayroll = 0m;
        foreach (Employee employee in employees)
        {
            decimal pay = employee.CalculatePay();
            Console.WriteLine($"{employee.Name} ({employee.GetType().Name}): {pay:C}");
            totalPayroll += pay;
        }

        Console.WriteLine();
        Console.WriteLine($"Total payroll: {totalPayroll:C}");
    }
}
