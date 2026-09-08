namespace CS1302.Lab05.StaticMembers.Models;

public static class UnitConverter
{
    private const double CentimetersPerInch = 2.54;
    private const double KilometersPerMile = 1.60934;

    private static int _conversionCount;

    public static int ConversionCount => _conversionCount;

    public static double CelsiusToFahrenheit(double celsius)
    {
        _conversionCount++;
        return (celsius * 9.0 / 5.0) + 32.0;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        _conversionCount++;
        return (fahrenheit - 32.0) * 5.0 / 9.0;
    }

    public static double MilesToKilometers(double miles)
    {
        _conversionCount++;
        return miles * KilometersPerMile;
    }

    public static double InchesToCentimeters(double inches)
    {
        _conversionCount++;
        return inches * CentimetersPerInch;
    }
}
