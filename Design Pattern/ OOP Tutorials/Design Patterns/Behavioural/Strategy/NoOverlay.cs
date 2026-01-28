using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class NoOverlay: IOverlay
{
    public void ApplyOverlay()
    {
        System.Console.WriteLine("Not applying an overlay");
    }
}
