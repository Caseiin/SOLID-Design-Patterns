using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.State;

public class Document
{
    public State State {get; set;}
    public UserRoles CurrentUserRole { get; set;}

    public Document(UserRoles currentUserRole)
    {
        State = new DraftDoc(this);
        CurrentUserRole = currentUserRole;
    }

    public void Publish()
    {
        State?.Publish();
    }
}
