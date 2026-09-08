using CS1302.Lab18.References.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab18_References_Tests
{
    [Fact]
    public void TryIncrementValue_Does_Not_Change_Callers_Copy()
    {
        int number = 5;

        ReferenceDemo.TryIncrementValue(number);

        Assert.Equal(5, number);
    }

    [Fact]
    public void IncrementCounter_Changes_Shared_Object()
    {
        Counter counter = new Counter(5);

        ReferenceDemo.IncrementCounter(counter);

        Assert.Equal(6, counter.Value);
    }

    [Fact]
    public void TryParseCoordinate_Parses_Valid_Input()
    {
        bool success = ReferenceDemo.TryParseCoordinate("3, 4", out int x, out int y);

        Assert.True(success);
        Assert.Equal(3, x);
        Assert.Equal(4, y);
    }

    [Fact]
    public void TryParseCoordinate_Rejects_Invalid_Input()
    {
        bool success = ReferenceDemo.TryParseCoordinate("not-a-coordinate", out int x, out int y);

        Assert.False(success);
    }
}
