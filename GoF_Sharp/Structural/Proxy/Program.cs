class Program
{
    public static void Main(string[] args)
    {
        Subject subject = new Proxy();
        subject.Request();
    }
}
abstract class Subject
{
    public abstract void Request();
}

class RealSubject : Subject
{
    public override void Request()
    {
        Console.WriteLine("RealSubject");
    }
}
class Proxy : Subject
{
    private RealSubject? _realSubject = null;
    public override void Request()
    {
        if(_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        _realSubject.Request();
    }
}