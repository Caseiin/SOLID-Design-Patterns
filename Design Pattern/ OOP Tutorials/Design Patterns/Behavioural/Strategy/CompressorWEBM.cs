using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class CompressorWEBM: ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing using WEBM");
    }
}