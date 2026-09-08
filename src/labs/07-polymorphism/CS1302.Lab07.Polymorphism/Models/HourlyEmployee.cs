namespace CS1302.Lab07.Polymorphism.Models;

public class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; }
    public double HoursWorked { get; }

    public HourlyEmployee(string name, decimal hourlyRate, double hoursWorked)
        : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return HourlyRate * (decimal)HoursWorked;
    }
}
