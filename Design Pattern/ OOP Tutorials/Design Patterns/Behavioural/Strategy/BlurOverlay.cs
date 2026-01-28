using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class BlurOverlay: IOverlay
{
    public void ApplyOverlay()
    {
        System.Console.WriteLine("Applying an Blur Overlay");
    }
}
