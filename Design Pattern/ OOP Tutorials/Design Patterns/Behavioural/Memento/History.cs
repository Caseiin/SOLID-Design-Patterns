using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Memento;

// CareTaker
public class History
{
    readonly List<EditorState> editorList = new List<EditorState>();
    Editor editor;


    public History(Editor editor)
    {
        this.editor = editor;
    }

    public void BackUp()
    {
        editorList.Add(editor.createState());
    }

    public void Undo()
    {
        if (editorList.Count == 0) return;

        var prevstate = editorList.Last();
        editorList.Remove(prevstate);
        editor.Restore(prevstate);
    }

    public void  ShowHistory()
    {
        System.Console.WriteLine("\n TimeLine of all mementos:");
        foreach(var state in editorList)
        {
            System.Console.WriteLine($"\n {state.Title} stored at: {state.stateDateCreatedAt}"); 
        }
    }
}
