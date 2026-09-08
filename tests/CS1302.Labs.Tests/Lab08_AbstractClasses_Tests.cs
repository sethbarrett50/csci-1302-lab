using CS1302.Lab08.AbstractClasses.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab08_AbstractClasses_Tests
{
    [Fact]
    public void EmailNotification_Send_WritesSubjectAndLogsChannel()
    {
        EmailNotification notification = new EmailNotification("test@example.com", "Hello");

        TextWriter original = Console.Out;
        StringWriter writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            notification.Send();
        }
        finally
        {
            Console.SetOut(original);
        }

        string output = writer.ToString();
        Assert.Contains("Hello", output);
        Assert.Contains("email", output);
    }

    [Fact]
    public void Notifications_Are_Polymorphic_Through_Base_Type()
    {
        List<Notification> notifications = new List<Notification>
        {
            new EmailNotification("a@example.com", "A"),
            new SmsNotification("555-0100", "B"),
            new PushNotification("user1", "App", "C"),
        };

        Assert.All(notifications, n => Assert.IsAssignableFrom<Notification>(n));
        Assert.Equal(3, notifications.Count);
    }
}
