using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command;

public class TurnOn : ICommand
{   
    Light _light;

    public TurnOn(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}
