using PolymorphismExample.Models;
using PolymorphismExample.Models.Impl;

var message = "This is a message";

INotification emailNotification = new EmailNotification();
Console.WriteLine("From emailnotification");
emailNotification.Send(message);

INotification smsNotification = new SMSNotification();
Console.WriteLine("From smsnotification");
smsNotification.Send(message);

INotification appNotification = new AppNotification();
Console.WriteLine("From appnotification");
appNotification.Send(message);
