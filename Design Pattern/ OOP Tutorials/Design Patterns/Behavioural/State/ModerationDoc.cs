using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.State;

public class ModerationDoc : State
{
    Document _document;

    public ModerationDoc(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        if (_document.CurrentUserRole == UserRoles.Admin)
        {
            _document.State = new PublishedDoc(_document);
        }
    }
}
