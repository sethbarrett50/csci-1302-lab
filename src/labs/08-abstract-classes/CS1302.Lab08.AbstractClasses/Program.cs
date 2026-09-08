using CS1302.Lab08.AbstractClasses.Models;

namespace CS1302.Lab08.AbstractClasses;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Abstract Classes Practice ==");
        Console.WriteLine();

        List<Notification> notifications = new List<Notification>
        {
            new EmailNotification("seth@example.com", "Welcome!"),
            new SmsNotification("555-0100", "Your code is 1234."),
            new PushNotification("seth", "MyApp", "You have a new message."),
        };

        foreach (Notification notification in notifications)
        {
            notification.Send();
            Console.WriteLine();
        }
    }
}
