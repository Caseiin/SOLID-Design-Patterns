using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command.Undoable;

public class UndoCommand : Command
{
    History _history;
    public UndoCommand(History history)
    {
        _history = history;
    }

    public void Execute()
    {
        if(_history.Size()> 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Unexecute(); //delegate undo logic to the undoCommand object
        }
    }
}
