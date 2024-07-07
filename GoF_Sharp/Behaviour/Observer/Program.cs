using System.Collections;
using System.Collections.Concurrent;

class Program
{
    public static void Main(string[] args)
    {
        ConcreteSubject subject = new ConcreteSubject();
        subject.Attach(new ConcreteObserver(subject));
        subject.Attach(new ConcreteObserver(subject));
        subject.State = "some state";
        subject.Notify();
    }
}
abstract class Subject
{
    private ArrayList _observers = new ArrayList();

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }
    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }
    public abstract string State { get; set; }

    public void Notify()
    {
        foreach (Observer el in _observers)
            el.Update(State);
    }
}
class ConcreteSubject : Subject
{
    public override string State { get; set; } = string.Empty;
}

interface Observer
{
    public abstract void Update(string state);
    //в модели pull void Update();
}
class ConcreteObserver : Observer
{
    private string _observerState = string.Empty;
    private ConcreteSubject _subject;
    public ConcreteObserver(ConcreteSubject subject)
    {
        this._subject = subject;
    }
    public void Update(string state)
    {
        //в модели pull _subject.state берется, а состояние
        //не заправш
        _observerState = state;
        Console.WriteLine("Updated!");
    }
}