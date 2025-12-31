using System;

namespace OOP_Tutorials;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        System.Console.WriteLine("Sms sending: " + message);
    }
}
