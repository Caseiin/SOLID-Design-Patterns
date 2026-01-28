using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class CompressorMOV: ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing using MOV");
    }
}
