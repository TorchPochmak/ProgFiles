class Program
{
    public static void Main(string[] args)
    {
        Component root = new Composite("root");
        Component branch1 = new Composite("branch1");
        branch1.Add(new Leaf("leaf11"));
        branch1.Add(new Leaf("leaf12"));

        Component branch2 = new Composite("branch2");
        branch2.Add(new Leaf("Leaf2"));

        root.Add(branch1);
        root.Add(branch2);
       
    }
}
abstract class Component
{
    protected string _name;
    public Component(string name)
    {
        _name = name;
    }
    public abstract void Operation();
    public virtual void Add(Component component)
    {
        throw new InvalidOperationException();
    }
    public virtual void Remove(Component component)
    {
        throw new InvalidOperationException();
    }
    public virtual Component GetChild(int index)
    {
        throw new InvalidOperationException();
    }
}
class Composite : Component
{
    List<Component> _nodes = new List<Component>();
    public Composite(string name) 
        : base(name) { }

    public override void Operation()
    {
        Console.WriteLine(_name);
        foreach(var component in _nodes)
        {
            component.Operation();
        }
    }

    public override void Add(Component component)
    {
        _nodes.Add(component);
    }

    public override void Remove(Component component)
    {
        _nodes.Remove(component);
    }

    public override Component GetChild(int index)
    {
        return _nodes[index];
    }
}

class Leaf : Component
{
    public Leaf(string name)
        : base(name) { }

    public override void Operation()
    {
        Console.WriteLine(_name);
    }

}
