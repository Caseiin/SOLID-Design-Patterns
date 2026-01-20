namespace OOP_Tutorials.Design_Patterns.Behavioural.State;

public enum DocumentState
{
    Draft,
    Moderation,
    Published
}
// This enum violates the State Pattern and Open Closed Principle as Each document state should be a concrete implementation of the base State.
// Which can self contain its on logic and behaviour.