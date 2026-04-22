using System.ComponentModel;
using System;
namespace  OOP_Tutorials.Design_Patterns.Behavioural.TemplateMethod;

public  abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();
        PourIntoCup();
        Brew();
        AddCondiments();
    }

    void BoilWater() => Console.WriteLine("Boiling water");
    void PourIntoCup()=> Console.WriteLine("Pouring water into cup");
    protected abstract void Brew();
    protected virtual void AddCondiments(){}
}
