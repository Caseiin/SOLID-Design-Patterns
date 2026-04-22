using System;
namespace OOP_Tutorials.Design_Patterns.Behavioural.TemplateMethod;

public class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("Steeping the tea");
    protected override void AddCondiments() => Console.WriteLine("Adding lemon");
}