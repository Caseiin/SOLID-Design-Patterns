// State Pattern

using OOP_Tutorials.Design_Patterns.Behavioural.State;

var doc = new Document(UserRoles.Admin);
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);


doc.State  = new DraftDoc(doc);
System.Console.WriteLine(doc.State);
