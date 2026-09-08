using CS1302.Lab17.Exceptions.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab17_Exceptions_Tests
{
    [Theory]
    [InlineData(2, 3, "+", 5)]
    [InlineData(5, 3, "-", 2)]
    [InlineData(4, 3, "*", 12)]
    [InlineData(10, 2, "/", 5)]
    public void Calculate_Returns_Correct_Result(int left, int right, string op, int expected)
    {
        Assert.Equal(expected, SafeCalculator.Calculate(left, right, op));
    }

    [Fact]
    public void Calculate_Throws_DivideByZeroException_On_Zero_Divisor()
    {
        Assert.Throws<DivideByZeroException>(() => SafeCalculator.Calculate(10, 0, "/"));
    }

    [Fact]
    public void Calculate_Throws_InvalidOperatorException_On_Unknown_Operator()
    {
        Assert.Throws<InvalidOperatorException>(() => SafeCalculator.Calculate(10, 2, "%"));
    }

    [Fact]
    public void Finally_Runs_Even_When_Exception_Is_Thrown()
    {
        bool finallyRan = false;

        try
        {
            SafeCalculator.Calculate(1, 0, "/");
        }
        catch (DivideByZeroException) { }
        finally
        {
            finallyRan = true;
        }

        Assert.True(finallyRan);
    }
}
