using System;

namespace OOP_Tutorials;

public class Vehicle
{
    public string Brand {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public virtual void Start()
    {
        System.Console.WriteLine("Vehicle is starting...");
    }

    public  virtual void Stop()
    {
        System.Console.WriteLine("Vehicle has stopped...");
    }    
}

/* This class makes use of the Inheritance OOP principle which involves creating new classes (subclasses) ;based on existing clsses (base classes). Sub-classes inherit properites and behaviours frome their base classes and also add new features/ override existing ones. Inheritance has a "Is a " relationship*/

