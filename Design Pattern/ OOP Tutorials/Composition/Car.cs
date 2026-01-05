using System;

namespace OOP_Tutorials;

public class Car : Vehicle
{
    Engine engine = new Engine();
    Chasis chasis = new Chasis();
    Seats seats = new Seats();

    public Car(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void Start()
    {
        engine.Start();
        seats.Sit();
        chasis.Support();
        System.Console.WriteLine("Car is starting");
    }
}

// Since Car "is a" vehicle. it inherits its properties and behaviours
