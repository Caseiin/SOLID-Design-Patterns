
using System.Drawing;
using OOP_Tutorials.Design_Patterns.Behavioural.Memento;
using OOP_Tutorials.SOLID.D;

var editor = new Editor();
var history = new History(editor);
history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "Hello this is a test";
history.BackUp();
editor.Title = "Life of a dev";

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Title: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Title: {editor.Content}");

history.ShowHistory();

