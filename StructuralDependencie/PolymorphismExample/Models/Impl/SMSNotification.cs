namespace PolymorphismExample.Models.Impl;

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS Notification: {message}");
    }
}