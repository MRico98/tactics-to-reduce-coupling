namespace PolymorphismExample.Models.Impl;

public class AppNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"App Notification Notification: {message}");
    }
}