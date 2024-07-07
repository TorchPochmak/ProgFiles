class Program
{
    public static void Main(string[] args)
    {
        Context c = new Context(new StateA());
        c.Request();
        c.Request();
    }
}
class Context
{
    public State State { get; set; }
    public Context(State state)
    {
        State = state;
    }
    public void Request()
    {
        State.Handle(this);
    }
}
abstract class State
{
    public abstract void Handle(Context context);
}
class StateA : State
{
    public override void Handle(Context c)
    {
        Console.WriteLine("State A changed to State B");
        c.State = new StateB();
    }
}
class StateB : State
{
    public override void Handle(Context c)
    {
        Console.WriteLine("State B changed to State A");
        c.State = new StateA();
    }
}