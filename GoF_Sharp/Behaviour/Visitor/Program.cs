using System.Collections;
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        var subject = new Subject();
        subject.Add(new ElementA());
        subject.Add(new ElementB());

        subject.Accept(new ConcreteVisitorB());
        Element element = new ElementA();
        BB bb = new BB();
        bb.a = 4;
        object h = (object)bb;
        object g = h;
        h = new BB();
        int j = ((BB)).a;
        Console.WriteLine(j);
    }
}
class BB
{
    public int a = 0;
}

class Subject
{
    private ArrayList _elements = new ArrayList();
    public void Add(Element el)
    {
        _elements.Add(el);
    }
    public void Remove(Element el)
    {
        _elements.Remove(el);
    }
    public void Accept(Visitor visitor)
    {
        foreach(Element el in _elements)
            el.Accept(visitor);
    }
}

#region VISITORS
abstract class Visitor
{
    public abstract void VisitA(ElementA elementA);
    public abstract void VisitB(ElementB elementB);

}
class ConcreteVisitorA : Visitor
{
    public override void VisitA(ElementA elementA)
    {
        elementA.OperationA();
    }

    public override void VisitB(ElementB elementB)
    {
        elementB.OperationB();
    }
}
class ConcreteVisitorB : Visitor
{
    public override void VisitA(ElementA elementA)
    {
        elementA.OperationA();
        Console.WriteLine("AOAO");
    }

    public override void VisitB(ElementB elementB)
    {
        elementB.OperationB();
    }
}
#endregion

abstract class Element
{
    public abstract void Accept(Visitor A);
}
class ElementA : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitA(this);
    }
    public void OperationA()
    {
        Console.WriteLine("OPERATION A");
    }
}
class ElementB : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitB(this);
    }
    public void OperationB()
    {
        Console.WriteLine("OPERATION B");
    }
}