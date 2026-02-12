namespace CS1302.Lab04.PropertiesExceptions.Models;

public class Temperature
{
    private const double AbsoluteZeroC = -273.15;

    private double _celsius;

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < AbsoluteZeroC)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    $"Temperature cannot be below absolute zero ({AbsoluteZeroC} C)."
                );
            }

            _celsius = value;
        }
    }

    public double Fahrenheit => (Celsius * 9.0 / 5.0) + 32.0;
}
