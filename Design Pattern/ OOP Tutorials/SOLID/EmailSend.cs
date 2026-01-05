using System;

namespace OOP_Tutorials.SOLID;

public class EmailSend
{
    public void Send(string email, string message)
    {
        System.Console.WriteLine($"Sending email to {email}: {message}");
    }
}
