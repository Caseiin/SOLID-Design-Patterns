using System;
namespace OOP_Tutorials.Design_Patterns.Behavioural.TemplateMethod;

public class Coffee : Beverage
{
    protected override void Brew() => Console.WriteLine("Brew coffee for 5 mins");
}