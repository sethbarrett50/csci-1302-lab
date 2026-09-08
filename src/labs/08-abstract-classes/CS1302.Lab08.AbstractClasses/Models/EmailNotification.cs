namespace CS1302.Lab08.AbstractClasses.Models;

public class EmailNotification : Notification
{
    public string Subject { get; }

    public EmailNotification(string recipient, string subject)
        : base(recipient)
    {
        Subject = subject;
    }

    public override void Send()
    {
        Console.WriteLine($"Emailing {Recipient}: \"{Subject}\"");
        LogSent("email");
    }
}
