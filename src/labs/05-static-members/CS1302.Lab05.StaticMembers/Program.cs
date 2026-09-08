using CS1302.Lab05.StaticMembers.Models;

namespace CS1302.Lab05.StaticMembers;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Static Members Practice ==");

        Console.WriteLine();
        Console.WriteLine("-- UnitConverter --");
        double f = UnitConverter.CelsiusToFahrenheit(100.0);
        Console.WriteLine($"100C -> {f}F");

        double km = UnitConverter.MilesToKilometers(5.0);
        Console.WriteLine($"5 miles -> {km:F2} km");

        double cm = UnitConverter.InchesToCentimeters(12.0);
        Console.WriteLine($"12 in -> {cm:F2} cm");

        Console.WriteLine();
        Console.WriteLine($"Total conversions performed: {UnitConverter.ConversionCount}");
    }
}
