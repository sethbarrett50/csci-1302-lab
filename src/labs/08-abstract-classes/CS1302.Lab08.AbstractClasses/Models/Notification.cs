namespace CS1302.Lab08.AbstractClasses.Models;

public abstract class Notification
{
    public string Recipient { get; }

    protected Notification(string recipient)
    {
        Recipient = recipient;
    }

    public abstract void Send();

    protected void LogSent(string channel)
    {
        Console.WriteLine($"[LOG] Sent {channel} notification to {Recipient}.");
    }
}
