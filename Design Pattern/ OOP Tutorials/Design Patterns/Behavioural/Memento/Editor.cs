using System;
using System.ComponentModel;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Memento;

// Originator
public class Editor
{
    public string Title;
    public string Content;

    public EditorState createState()
    {
        return new EditorState(Title, Content);
    }

    public void Restore(EditorState state)
    {
        Title = state.Title;
        Content = state.Content;
    }


}
