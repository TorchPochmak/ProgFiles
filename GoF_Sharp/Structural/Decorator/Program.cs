using System.ComponentModel;

class Program
{
    public static void Main(string[] args)
    {
        Component op = new Hamster();
        Decorator decorator1 = new StateDecorator();
        Decorator decorator2 = new BehaveDecorator();

        decorator1.Connector = op;
        decorator2.Connector = decorator1;
        decorator2.Operation();
    }
}

abstract class Component
{
    public abstract void Operation();
}

class Hamster : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent1");
    }
}

abstract class Decorator : Component
{
    public Component? Connector { protected get; set; }

    public override void Operation()
    {
        if (Connector != null)
            Connector.Operation();
    }
}

class StateDecorator : Decorator
{
    string _newState = "State1";

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine(_newState);
    }
}
class BehaveDecorator : Decorator
{
    void NewBehavior()
    {
        Console.WriteLine("New Behaviour!");
    }
    public override void Operation()
    {
        base.Operation();
        NewBehavior();
    }
}
