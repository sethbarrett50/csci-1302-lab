using CS1302.Lab10.Generics.Models;

namespace CS1302.Lab10.Generics;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Generics Practice ==");
        Console.WriteLine();

        Pair<int, string> idAndName = new Pair<int, string>(1, "Alex");
        Console.WriteLine(idAndName.Describe());

        Pair<string, string> nameAndCity = new Pair<string, string>("Bailey", "Athens");
        Console.WriteLine(nameAndCity.Describe());

        Console.WriteLine();
        int x = 1;
        int y = 2;
        Console.WriteLine($"Before swap: x={x}, y={y}");
        GenericTools.Swap(ref x, ref y);
        Console.WriteLine($"After swap: x={x}, y={y}");

        Console.WriteLine();
        string first = "first";
        string second = "second";
        Console.WriteLine($"Before swap: first={first}, second={second}");
        GenericTools.Swap(ref first, ref second);
        Console.WriteLine($"After swap: first={first}, second={second}");
    }
}
