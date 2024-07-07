using System.Collections.Generic;
namespace Creational
{
    //ICloneable
    class Program
    {
        public static void Main(string[] args)
        {
            Prototype original = new ConcretePrototype1(4);
            Prototype clone = original.Clone();
            Console.WriteLine(clone.Id);
        }
    }
    abstract class Prototype
    {
        public int Id { get; private set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base (id) { }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2 (int id) : base(id) { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }

}