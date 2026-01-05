using System;

namespace OOP_Tutorials.SOLID.O;

public class Circle : Shape
{
    public double Radius {get; set;}
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius,2);
    }
}
