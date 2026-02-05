// Command pattern with undoable

using OOP_Tutorials.Design_Patterns.Behavioural.Command.Undoable;

var htlmDoc = new HtmlDocument();
var history = new History();
htlmDoc.Content = "Hello world";
System.Console.WriteLine(htlmDoc.Content); //Hello world

var ItalicCommand = new ItalicCommand(htlmDoc,history);
ItalicCommand.Execute();
System.Console.WriteLine(htlmDoc.Content);//<i>Hello world<i>


var undoCommand = new UndoCommand(history);
undoCommand.Execute();
System.Console.WriteLine(htlmDoc.Content); //Hello world



