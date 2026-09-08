using CS1302.Lab09.Interfaces.Models;

namespace CS1302.Lab09.Interfaces;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Interfaces Practice ==");
        Console.WriteLine();

        List<IPlayable> playlist = new List<IPlayable>
        {
            new Song("Clair de Lune", "Debussy"),
            new Podcast("Code Review", 42),
            new AudioBook("Dune", "Simon Vance"),
        };

        foreach (IPlayable item in playlist)
        {
            item.Play();
            item.Stop();
            Console.WriteLine();
        }
    }
}
