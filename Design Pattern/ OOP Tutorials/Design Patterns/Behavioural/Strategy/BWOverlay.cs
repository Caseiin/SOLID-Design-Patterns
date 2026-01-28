using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class BWOverlay : IOverlay
{
    public void ApplyOverlay()
    {
        System.Console.WriteLine("Applying an Black and White Overlay");
    }
}
