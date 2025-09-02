namespace PolymorphismExample.Models.Impl;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Email Notification: {message}");
    }
}
