class Program
{
    public static void Main(string[] args)
    {
        BaseClass a = new ConcreteClass();
        a.TemplateMethod();
    }
}
abstract class BaseClass
{
    protected abstract void Method1();
    protected abstract void Method2();
    public void TemplateMethod()
    {
        Method1();
        Console.WriteLine("LOL TEMPLATE METHOD");
        Method2();
    }
}
class ConcreteClass : BaseClass
{

    protected override void Method1()
    {
        Console.WriteLine("LOL METHOD1 override");
    }

    protected override void Method2()
    {
        Console.WriteLine("LOL METHOD2 override");
    }
}