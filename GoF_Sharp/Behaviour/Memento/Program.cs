class Program
{
    public static void Main(string[] args)
    {
        Originator originator = new Originator();
        Console.WriteLine(originator.State);

        originator.State = "STATE LOL";
        Console.WriteLine(originator.State);

        Caretaker taker = new Caretaker();
        taker.Memento = originator.CreateMemento();

        originator = new Originator();
        Console.WriteLine(originator.State);
        originator.SetMemento(taker.Memento);
        Console.WriteLine(originator.State);


    }
}
class Memento
{
    public string State { get; private set; }
    public Memento(string state)
    {
        this.State = state;
    }
}

class Caretaker
{
    public Memento? Memento { get; set; }
}

class Originator
{
    public string State { get; set; } = "NO STATE LOL";
    public void SetMemento(Memento memento)
    {
        State = memento.State;
    }
    public Memento CreateMemento()
    {
        return new Memento(State);
    }
}