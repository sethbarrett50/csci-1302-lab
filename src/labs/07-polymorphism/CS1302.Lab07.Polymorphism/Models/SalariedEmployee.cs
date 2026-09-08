namespace CS1302.Lab07.Polymorphism.Models;

// sealed: no further subclasses are planned, and this is the lab where
// `sealed` actually belongs (see issue #7 — it was deferred out of the
// earlier UML lab until polymorphism was covered in lecture).
public sealed class SalariedEmployee : Employee
{
    private const int PayPeriodsPerYear = 26;

    public decimal AnnualSalary { get; }

    public SalariedEmployee(string name, decimal annualSalary)
        : base(name)
    {
        AnnualSalary = annualSalary;
    }

    public override decimal CalculatePay()
    {
        return AnnualSalary / PayPeriodsPerYear;
    }
}
