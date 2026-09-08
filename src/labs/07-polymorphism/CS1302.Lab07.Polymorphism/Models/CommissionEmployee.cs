namespace CS1302.Lab07.Polymorphism.Models;

public class CommissionEmployee : Employee
{
    public decimal BaseSalary { get; }
    public decimal SalesTotal { get; }
    public decimal CommissionRate { get; }

    public CommissionEmployee(
        string name,
        decimal baseSalary,
        decimal salesTotal,
        decimal commissionRate
    )
        : base(name)
    {
        BaseSalary = baseSalary;
        SalesTotal = salesTotal;
        CommissionRate = commissionRate;
    }

    public override decimal CalculatePay()
    {
        return BaseSalary + (SalesTotal * CommissionRate);
    }
}
