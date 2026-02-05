using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command.Undoable;

public interface UndoableCommand : Command
{
    void Unexecute();
}
