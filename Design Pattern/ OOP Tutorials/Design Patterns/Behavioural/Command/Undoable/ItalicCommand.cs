using System;
using System.Reflection.Metadata;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command.Undoable;

public class ItalicCommand : UndoableCommand
{
    private HtmlDocument _doc;
    private string _preContent = "";
    private History _history;

    public ItalicCommand(HtmlDocument doc, History history)
    {
        _doc = doc;
        _history = history;
    }

    public void Execute()
    {
        _preContent = _doc.Content;
        _doc.MakeItalic(); // delegate this work to doc business object
        _history.Push(this);
    }

    public void Unexecute()
    {
        _doc.Content = _preContent;
        
    }
}
