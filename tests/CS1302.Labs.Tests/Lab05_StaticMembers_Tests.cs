using CS1302.Lab05.StaticMembers.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab05_StaticMembers_Tests
{
    [Fact]
    public void CelsiusToFahrenheit_Converts_Correctly()
    {
        double result = UnitConverter.CelsiusToFahrenheit(0.0);

        Assert.Equal(32.0, result);
    }

    [Fact]
    public void ConversionCount_Increments_Across_Calls()
    {
        int before = UnitConverter.ConversionCount;

        UnitConverter.MilesToKilometers(1.0);
        UnitConverter.InchesToCentimeters(1.0);

        int after = UnitConverter.ConversionCount;

        Assert.Equal(before + 2, after);
    }
}
