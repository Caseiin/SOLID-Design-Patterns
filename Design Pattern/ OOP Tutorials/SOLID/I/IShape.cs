using System;

namespace OOP_Tutorials.SOLID.I;

public interface IShape
{
    double Area();
    double Volume();
}

// This class breaks the Interface Segregation principle as not all shapes have Volumes such as 2D shapes