using System;

namespace OOP_Tutorials.SOLID.I;

public interface IShape2D
{
    double Area();
}

// This separation or segregation of interfaces ensures the client does not need to depend on things they dont need
