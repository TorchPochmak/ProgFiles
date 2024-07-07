using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        Receiver receiver = new Receiver();
        Command command = new ConcreteCommand(receiver);
        Invoker invoker = new Invoker();

        invoker.StoreCommand(command);
        invoker.ExecuteCommand();

    }
}
class Invoker //WTF санстрайк?
{
    private Command? _command;

    public void StoreCommand(Command command)
    {
        _command = command;
    }
    public void ExecuteCommand()
    {
        _command?.Execute();
    }
}

abstract class Command
{
    protected Receiver _receiver;
    public Command(Receiver receiver)
    {
        this._receiver = receiver;
    }
    public abstract void Execute();
}
class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver)
        : base(receiver) { }

    public override void Execute()
    {
        _receiver.Action();
    }
}
class Receiver
{
    public void Action()
    {
        Console.WriteLine("Receiver got command");
    }
}