namespace CS1302.Lab08.AbstractClasses.Models;

public class PushNotification : Notification
{
    public string AppName { get; }
    public string Message { get; }

    public PushNotification(string recipient, string appName, string message)
        : base(recipient)
    {
        AppName = appName;
        Message = message;
    }

    public override void Send()
    {
        Console.WriteLine($"[{AppName}] push to {Recipient}: {Message}");
        LogSent("push");
    }
}
