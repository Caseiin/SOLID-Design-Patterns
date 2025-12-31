using System;

namespace OOP_Tutorials;

public class EmailSender : INotificationService
{

    public void SendNotification(string message)
    {
        // Email Sending logic
        System.Console.WriteLine("Email sending:" +message);
        
    }
}

/* This class makes use of the Coupling OOP principle which describes the relationship between different classes. High coupling usually bad makes it difficult for the classes to be modified
and therefore in less flexible which is not valued */
