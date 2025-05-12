// The Memento pattern provides the ability to restore an object to its previous state.

// Theory: It captures and externalizes an object's internal state so that the object can be restored to this state later.

public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}

public class Originator
{
    public string State { get; set; }

    public Memento SaveState()
    {
        return new Memento(State);
    }

    public void RestoreState(Memento memento)
    {
        State = memento.State;
    }
}

public class Caretaker
{
    private Memento _memento;

    public void SaveState(Originator originator)
    {
        _memento = originator.SaveState();
    }

    public void RestoreState(Originator originator)
    {
        originator.RestoreState(_memento);
    }
}
