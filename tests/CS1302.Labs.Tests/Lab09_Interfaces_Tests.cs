using CS1302.Lab09.Interfaces.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab09_Interfaces_Tests
{
    [Fact]
    public void Song_Implements_IPlayable()
    {
        IPlayable playable = new Song("Test Song", "Test Artist");

        Assert.IsAssignableFrom<IPlayable>(playable);
    }

    [Fact]
    public void List_Of_IPlayable_Calls_Correct_Implementation()
    {
        List<IPlayable> playlist = new List<IPlayable>
        {
            new Song("A", "B"),
            new Podcast("C", 1),
            new AudioBook("D", "E"),
        };

        TextWriter original = Console.Out;
        StringWriter writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            foreach (IPlayable item in playlist)
            {
                item.Play();
            }
        }
        finally
        {
            Console.SetOut(original);
        }

        string output = writer.ToString();
        Assert.Contains("song \"A\"", output);
        Assert.Contains("C, episode 1", output);
        Assert.Contains("audiobook \"D\"", output);
    }
}
