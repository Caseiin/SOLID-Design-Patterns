using System;
using System.Dynamic;

namespace OOP_Tutorials.SOLID.L;

public class Square : Shape
{
    public double SideLength{get; set;}
    public override double Area => SideLength * SideLength;
}
