using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        Aggregate a = new ArrayListAggregate();
        a[0] = "0";
        a[1] = "1";
        a[2] = "2";

        Iterator i = a.CreateReverseIterator();
        for(object? el = i.First(); !i.IsDone(); el = i.Next())
        {
            Console.WriteLine(el);
        }
    }
}
abstract class Aggregate
{
    public abstract Iterator CreateReverseIterator();
    public abstract int Count { get; }
    public abstract object this[int index] { get; set; }

}
class ArrayListAggregate : Aggregate
{
    private ArrayList _items = new ArrayList();
    public override Iterator CreateReverseIterator()
    {
        return new ReverseIterator(this);
    }
    public override int Count
    {
        get { return _items.Count; }
    }
    public override object this[int index]
    {
        get { return index >= 0 && index < Count ? _items[index] : null; }
        set { _items.Insert(index, value); }
    }
}
abstract class Iterator
{
    public abstract object? First();
    public abstract object? Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
    public abstract void ResetIterator();
}

class ReverseIterator : Iterator
{
    private Aggregate _aggregate;
    private int _position;
    public ReverseIterator(Aggregate aggregate)
    {
        _aggregate = aggregate;
        _position = _aggregate.Count - 1;
    }
    public override object First()
    {
        return _aggregate[_aggregate.Count - 1];
    }
    public override object? Next()
    {
        if (_position-- >= 0)
        {
            return _aggregate[_position];
        }
        else
            return null;
    }
    public override object CurrentItem()
    {
        return _aggregate[_position];
    }
    public override bool IsDone()
    {
        if (_position < 0)
            return true;
        else
            return false;
    }
    public override void ResetIterator()
    {
        _position = _aggregate.Count - 1;
    }
}

