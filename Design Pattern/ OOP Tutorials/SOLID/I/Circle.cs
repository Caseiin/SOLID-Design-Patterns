using System;

namespace OOP_Tutorials.SOLID.I;

public class Circle : IShape2D
{
    public double Radius {get; set;}

    public double Area()
    {
        return Math.PI* Math.Pow(Radius,2);
    }

    public double Volume()
    {
        throw new InvalidOperationException("Volume not applicable for 2D shapes");
    }
}
