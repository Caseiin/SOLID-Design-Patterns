using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Command.Undoable;

public class HtmlDocument
{
    public string Content {get;set;}

    public void MakeItalic()
    {
        Content = "<i>"+ Content +"<i>";
    }
}
