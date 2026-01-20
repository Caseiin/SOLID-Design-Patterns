using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.State;

public class DraftDoc: State
{
    Document _document;

    public DraftDoc(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        _document.State =  new ModerationDoc(_document);
    }
}
