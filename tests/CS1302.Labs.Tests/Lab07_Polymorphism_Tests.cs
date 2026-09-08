using CS1302.Lab07.Polymorphism.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab07_Polymorphism_Tests
{
    [Fact]
    public void HourlyEmployee_CalculatesPay_FromRateAndHours()
    {
        HourlyEmployee employee = new HourlyEmployee("Test", 20m, 40.0);

        Assert.Equal(800m, employee.CalculatePay());
    }

    [Fact]
    public void SalariedEmployee_CalculatesPay_AsAnnualOverPayPeriods()
    {
        SalariedEmployee employee = new SalariedEmployee("Test", 26000m);

        Assert.Equal(1000m, employee.CalculatePay());
    }

    [Fact]
    public void CommissionEmployee_CalculatesPay_AsBasePlusCommission()
    {
        CommissionEmployee employee = new CommissionEmployee("Test", 100m, 1000m, 0.1m);

        Assert.Equal(200m, employee.CalculatePay());
    }

    [Fact]
    public void List_Of_Employee_Dispatches_To_Correct_Override()
    {
        List<Employee> employees = new List<Employee>
        {
            new HourlyEmployee("A", 10m, 10.0),
            new SalariedEmployee("B", 26000m),
            new CommissionEmployee("C", 100m, 1000m, 0.1m),
        };

        decimal total = 0m;
        foreach (Employee employee in employees)
        {
            total += employee.CalculatePay();
        }

        Assert.Equal(1300m, total);
    }
}
