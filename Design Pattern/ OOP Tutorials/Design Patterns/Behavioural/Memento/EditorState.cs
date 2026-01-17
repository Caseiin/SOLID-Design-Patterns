using System;
using System.Reflection;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Memento;

// Memento
public class EditorState
{
    readonly string title;
    readonly string content;
    // Memento Meta Data
    readonly DateTime _stateDateCreatedAt;


    // public fields
    public string Title => title;
    public string Content => content;
    public DateTime stateDateCreatedAt => _stateDateCreatedAt;


    public EditorState(string title, string Content)
    {
        this.title = title;
        this.content = Content;
        _stateDateCreatedAt = DateTime.Now;
    }
}
