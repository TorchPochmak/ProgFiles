class Program
{
    public static void Main(string[] args)
    {
        ConcreteMediator mediator = new ConcreteMediator();
        var colleague1 = new ConcreteColleague1(mediator);
        var colleague2 = new ConcreteColleague2(mediator);
        mediator.Colleague1 = colleague1;
        mediator.Colleague2 = colleague2;
        colleague1.Send("Message sent from colleague 1");
        colleague2.Send("Message sent from colleague 2");
    }
}
abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}
class ConcreteMediator : Mediator
{
    public ConcreteColleague1 Colleague1 { get; set; }
    public ConcreteColleague2 Colleague2 { get; set; }
    public override void Send(string msg, Colleague colleague)
    {
        if (colleague == Colleague1)
            Colleague2.Notify(msg);
        else
            Colleague1.Notify(msg);
    }
}
abstract class Colleague
{
    protected Mediator _mediator;
    public Colleague(Mediator mediator)
    {
        _mediator = mediator;
    }
    public abstract void Send(string msg);

    public abstract void Notify(string msg);
}
class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator)
        : base(mediator) { }

    public override void Send(string msg)
    {
        _mediator.Send(msg, this);
    }
    public override void Notify(string msg)
    {
        Console.WriteLine(msg);
        Console.WriteLine("Colleague 1 has been notified and printed this");
    }
}
class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator)
        : base(mediator) { }

    public override void Send(string msg)
    {
        _mediator.Send(msg, this);
    }
    public override void Notify(string msg)
    {
        Console.WriteLine(msg);
        Console.WriteLine("Colleague 2 has been notified and printed this");
    }
}