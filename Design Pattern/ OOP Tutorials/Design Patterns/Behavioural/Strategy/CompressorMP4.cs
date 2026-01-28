using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class CompressorMP4 : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing using MP4");
    }
}
