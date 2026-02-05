using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command;

// Receiver class
public class Light
{
    public void TurnOn()
    {
        System.Console.WriteLine("Light is on!");
    }
    public void TurnOff()
    {
        System.Console.WriteLine("Light is off!");
    }
}

