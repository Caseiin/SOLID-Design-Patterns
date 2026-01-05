using System;

namespace OOP_Tutorials.SOLID.O;

public abstract class Shape
{
    public abstract double CalculateArea();
}

// This class shows the OCP (Open-Closed ) principle where classes should be open for extension but closed for modification
// Meaning adding new classes for extension but dont modify source code 