namespace CS1302.Lab09.Interfaces.Models;

public class Podcast : IPlayable
{
    public string ShowName { get; }
    public int EpisodeNumber { get; }

    public Podcast(string showName, int episodeNumber)
    {
        ShowName = showName;
        EpisodeNumber = episodeNumber;
    }

    public void Play()
    {
        Console.WriteLine($"Playing {ShowName}, episode {EpisodeNumber}.");
    }

    public void Stop()
    {
        Console.WriteLine($"Stopped {ShowName}, episode {EpisodeNumber}.");
    }
}
