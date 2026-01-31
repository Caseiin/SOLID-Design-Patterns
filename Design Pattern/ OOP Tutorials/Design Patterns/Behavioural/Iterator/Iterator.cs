using System;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Iterator;

public interface Iterator<T>
{
    void Next();
    T Current();
    bool HasNext();

}
