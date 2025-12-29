using System;

namespace OOP_Tutorials;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        System.Console.WriteLine("Sending Email...");
        Disconnect();
    }

    // Client only needs to be aware of method SendEmail() which makes use of other methods. In this way the we have abstracted the work for the client

    void Connect()
    {
        System.Console.WriteLine("Connecting to email server...");
    }

    void Disconnect()
    {
        System.Console.WriteLine("Disconnecting...");
    }

    void Authenticate()
    {
        System.Console.WriteLine("Authenticating ...");
    }
}
/* This class makes use of the Abstraction OOP principle which ensures internal implementation is hidden and only
necessary data can be viewed externally. This adds security and control for the program. And prevents direct access from Client. The inner working of the class has been abstract making it easier for the client to make use of the program. Only needs one method */
