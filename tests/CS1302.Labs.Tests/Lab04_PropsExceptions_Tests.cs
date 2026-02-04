using CS1302.Lab04.PropertiesExceptions.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public sealed class Lab04_PropsExceptions_Tests
{
    [Fact]
    public void BankAccount_Rejects_Overdraft()
    {
        var acct = new BankAccount("Test", 10m);

        Assert.Throws<InvalidOperationException>(() => acct.Withdraw(11m));
        Assert.Equal(10m, acct.Balance);
    }

    [Fact]
    public void Temperature_Rejects_BelowAbsoluteZero()
    {
        var t = new Temperature(0.0);

        Assert.Throws<ArgumentOutOfRangeException>(() => t.Celsius = -999.0);
    }
}
