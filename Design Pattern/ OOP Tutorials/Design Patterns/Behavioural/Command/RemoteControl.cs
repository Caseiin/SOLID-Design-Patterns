using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command;

// Sender class
public class RemoteControl
{
    ICommand _command;


    public RemoteControl(ICommand command)
    {
        _command = command;
    }

    public void PressButtton()
    {
        _command.Execute();
    }

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
}
