using System;

namespace OOP_Tutorials.SOLID;

public class UserService
{
    public void Register(User user)
    {
        // Register user logic...

        // Send email
        var emailSender = new EmailSend();
        emailSender.Send(user.Email,"Welcome to the Platform!");
    }
}
// This class adheres to the SRP (single Responsibility Principle) where a chass should only have one reason to change or one purpose
