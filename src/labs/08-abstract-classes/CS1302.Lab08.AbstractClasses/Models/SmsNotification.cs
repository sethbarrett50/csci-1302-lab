namespace CS1302.Lab08.AbstractClasses.Models;

public class SmsNotification : Notification
{
    public string Message { get; }

    public SmsNotification(string recipient, string message)
        : base(recipient)
    {
        Message = message;
    }

    public override void Send()
    {
        Console.WriteLine($"Texting {Recipient}: {Message}");
        LogSent("SMS");
    }
}
