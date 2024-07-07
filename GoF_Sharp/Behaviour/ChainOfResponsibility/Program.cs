class Program
{
    public static void Main(string[] args)
    {
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();

        h1.Successor = h2;
        h1.Handle(1);
        h1.Handle(-1000);
    }
}
abstract class Handler
{
    public abstract void Handle(int request);
    public Handler? Successor { get; set; } = null;
    public abstract bool Validate(int request);
}
class ConcreteHandler1 : Handler
{
    public override bool Validate(int request)
    {
        return request == 1;
    }
    public override void Handle(int request)
    {
        if (Validate(request))
            Console.WriteLine("Request handled - ONE");
        else if (Successor != null)
            Successor.Handle(request);
        else
            throw new Exception("Unknown request");
    }
}
class ConcreteHandler2 : Handler
{
    public override bool Validate(int request)
    {
        return true;
    }
    public override void Handle(int request)
    {
        if (Validate(request))
            Console.WriteLine("Request handled - Everything!");
        else if (Successor != null)
            Successor.Handle(request);
        else
            throw new Exception("Unknown request");
    }
}

