using CS1302.Lab10.Generics.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab10_Generics_Tests
{
    [Fact]
    public void Pair_Describe_Works_With_Mixed_Types()
    {
        Pair<int, string> pair = new Pair<int, string>(1, "Alex");

        Assert.Equal("(1, Alex)", pair.Describe());
    }

    [Fact]
    public void Pair_Works_With_Same_Type_Arguments()
    {
        Pair<string, string> pair = new Pair<string, string>("A", "B");

        Assert.Equal("(A, B)", pair.Describe());
    }

    [Fact]
    public void Swap_Works_For_Value_Types()
    {
        int a = 1;
        int b = 2;

        GenericTools.Swap(ref a, ref b);

        Assert.Equal(2, a);
        Assert.Equal(1, b);
    }

    [Fact]
    public void Swap_Works_For_Reference_Types()
    {
        string a = "first";
        string b = "second";

        GenericTools.Swap(ref a, ref b);

        Assert.Equal("second", a);
        Assert.Equal("first", b);
    }
}
