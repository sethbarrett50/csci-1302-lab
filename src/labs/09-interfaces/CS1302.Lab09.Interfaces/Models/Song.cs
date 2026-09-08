namespace CS1302.Lab09.Interfaces.Models;

public class Song : IPlayable
{
    public string Title { get; }
    public string Artist { get; }

    public Song(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }

    public void Play()
    {
        Console.WriteLine($"Playing song \"{Title}\" by {Artist}.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopped song \"{Title}\".");
    }
}
