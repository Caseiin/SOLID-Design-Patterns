using System;

namespace OOP_Tutorials.SOLID.L;

public class Rectangle : Shape
{
    public virtual double Width {get;set;}
    public virtual double Length {get;set;}


    public override double Area => Width * Length;
}
