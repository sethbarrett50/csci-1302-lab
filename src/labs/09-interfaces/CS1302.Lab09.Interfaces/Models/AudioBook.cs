namespace CS1302.Lab09.Interfaces.Models;

public class AudioBook : IPlayable
{
    public string Title { get; }
    public string Narrator { get; }

    public AudioBook(string title, string narrator)
    {
        Title = title;
        Narrator = narrator;
    }

    public void Play()
    {
        Console.WriteLine($"Playing audiobook \"{Title}\", narrated by {Narrator}.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopped audiobook \"{Title}\".");
    }
}
