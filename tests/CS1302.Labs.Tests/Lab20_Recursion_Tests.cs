using CS1302.Lab20.Recursion.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab20_Recursion_Tests
{
    [Fact]
    public void Sum_Returns_Zero_For_Empty_Array()
    {
        Assert.Equal(0, RecursiveMath.Sum(Array.Empty<int>()));
    }

    [Fact]
    public void Sum_Adds_All_Elements()
    {
        Assert.Equal(15, RecursiveMath.Sum(new[] { 1, 2, 3, 4, 5 }));
    }

    [Fact]
    public void Reverse_Returns_Same_String_For_Empty_Or_Single_Char()
    {
        Assert.Equal(string.Empty, RecursiveMath.Reverse(string.Empty));
        Assert.Equal("a", RecursiveMath.Reverse("a"));
    }

    [Fact]
    public void Reverse_Reverses_Longer_String()
    {
        Assert.Equal("olleh", RecursiveMath.Reverse("hello"));
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(10, 55)]
    public void Fibonacci_Returns_Correct_Value(int n, int expected)
    {
        Assert.Equal(expected, RecursiveMath.Fibonacci(n));
    }
}
