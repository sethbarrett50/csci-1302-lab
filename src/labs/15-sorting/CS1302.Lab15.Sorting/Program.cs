using CS1302.Lab15.Sorting.Models;

namespace CS1302.Lab15.Sorting;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Sorting Practice ==");
        Console.WriteLine();

        int[] bubbleData = { 5, 2, 8, 1, 9, 3 };
        Console.WriteLine($"Before: {string.Join(", ", bubbleData)}");
        Sorter.BubbleSort(bubbleData);
        Console.WriteLine($"After BubbleSort: {string.Join(", ", bubbleData)}");

        Console.WriteLine();
        int[] selectionData = { 5, 2, 8, 1, 9, 3 };
        Console.WriteLine($"Before: {string.Join(", ", selectionData)}");
        Sorter.SelectionSort(selectionData);
        Console.WriteLine($"After SelectionSort: {string.Join(", ", selectionData)}");
    }
}
