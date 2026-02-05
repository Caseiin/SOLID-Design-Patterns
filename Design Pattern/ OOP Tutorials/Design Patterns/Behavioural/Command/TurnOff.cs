using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command;

public class TurnOff:ICommand
{   
    Light _light;

    public TurnOff(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}