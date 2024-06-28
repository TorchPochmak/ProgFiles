
class Program
{
    static void Main(string[] args)
    {
        Abstraction abstraction = new RefinedAbstraction(
            new ConcreteImplementor1());
        abstraction.Operation();

        abstraction = new RefinedAbstraction(
            new ConcreteImplementor2());

        abstraction.Operation();
    }
}
abstract class Implementor
{
    public abstract void OperationImp();
}
class ConcreteImplementor1 : Implementor
{
    public override void OperationImp()
    {
        Console.WriteLine("Implementor1");
    }
}
class ConcreteImplementor2 : Implementor
{
    public override void OperationImp()
    {
        Console.WriteLine("Implementor2");
    }
}
abstract class Abstraction
{
    protected Implementor _implementor;
    public Abstraction(Implementor imp)
    {
        this._implementor = imp;
    }
    public virtual void Operation()
    {
        _implementor.OperationImp();
    }
}
class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(Implementor implementor) :
        base(implementor)
    { }

    public override void Operation()
    {
        Console.WriteLine("Bridge lol");
        base.Operation();
        Console.WriteLine("Bridge damn");
    }

}
