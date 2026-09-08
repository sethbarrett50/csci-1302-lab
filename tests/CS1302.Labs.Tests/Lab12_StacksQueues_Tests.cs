using CS1302.Lab12.StacksQueues.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab12_StacksQueues_Tests
{
    [Theory]
    [InlineData("([]{})", true)]
    [InlineData("((()))", true)]
    [InlineData("", true)]
    [InlineData("([)]", false)]
    [InlineData("(]", false)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    public void IsBalanced_Returns_Expected_Result(string expression, bool expected)
    {
        Assert.Equal(expected, BalancedParenthesesChecker.IsBalanced(expression));
    }

    [Fact]
    public void PrintQueueSimulator_Processes_In_FifoOrder()
    {
        PrintQueueSimulator printer = new PrintQueueSimulator();
        printer.Enqueue("first");
        printer.Enqueue("second");
        printer.Enqueue("third");

        Assert.Equal("first", printer.ProcessNext());
        Assert.Equal("second", printer.ProcessNext());
        Assert.Equal("third", printer.ProcessNext());
        Assert.Equal(0, printer.PendingCount);
    }

    [Fact]
    public void PrintQueueSimulator_Throws_When_Empty()
    {
        PrintQueueSimulator printer = new PrintQueueSimulator();

        Assert.Throws<InvalidOperationException>(() => printer.ProcessNext());
    }
}
