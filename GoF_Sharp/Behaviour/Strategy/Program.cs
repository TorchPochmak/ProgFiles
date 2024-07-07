class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context(new StrategyA());
        context.ContextMethod();
        context = new Context(new StrategyB());
        context.ContextMethod();
    }
}
class Context
{
    private IStrategy _strategy;
    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }   
    public void ContextMethod()
    {
        _strategy.Method();
    }
}
interface IStrategy
{
    public void Method();
}
class StrategyA : IStrategy
{
    public void Method()
    {
        Console.WriteLine("StrategyA");
    }
}
class StrategyB : IStrategy
{
    public void Method()
    {
        Console.WriteLine("StrategyB");
    }
}


