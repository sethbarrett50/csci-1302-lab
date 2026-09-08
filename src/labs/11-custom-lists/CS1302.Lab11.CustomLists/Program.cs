using CS1302.Lab11.CustomLists.Models;

namespace CS1302.Lab11.CustomLists;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Custom Lists Practice ==");
        Console.WriteLine();

        SimpleLinkedList<string> names = new SimpleLinkedList<string>();
        names.Add("Alex");
        names.Add("Bailey");
        names.Add("Casey");

        Console.WriteLine($"Count: {names.Count}");
        foreach (string name in names)
        {
            Console.WriteLine($"- {name}");
        }

        Console.WriteLine();
        Console.WriteLine($"Contains 'Bailey': {names.Contains("Bailey")}");
        Console.WriteLine($"Contains 'Drew': {names.Contains("Drew")}");

        Console.WriteLine();
        names.RemoveFirst();
        Console.WriteLine($"After RemoveFirst, count: {names.Count}");
        foreach (string name in names)
        {
            Console.WriteLine($"- {name}");
        }
    }
}
