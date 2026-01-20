using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.State;

public class PublishedDoc : State
{
    Document document;

    public PublishedDoc(Document document)
    {
        this.document = document;
    }


    public void Publish()
    {
        // no op if already in published state
    }
}
