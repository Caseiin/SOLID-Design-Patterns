using System;

namespace OOP_Tutorials;

public class Car : Vehicle
{
    public Car(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void Start()
    {
        System.Console.WriteLine("Car is starting");
    }
}

// Since Car "is a" vehicle. it inherits its properties and behaviours
