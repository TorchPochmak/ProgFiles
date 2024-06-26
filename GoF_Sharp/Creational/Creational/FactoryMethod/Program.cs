using System.Collections.Generic;
namespace Creational
{
    class Program
    {
        public static void Main(string[] args)
        {
            Creator creator1 = new Creator1();
            Product product1 = creator1.FactoryMethod();
        }

        public void Create(Creator create)
        {

        }
    }
    abstract class Product { };

    class Product1 : Product
    {
        public Product1() 
        {
            Console.WriteLine("Product 1");
        }
    }
    class Product2 : Product
    {
        public Product2()
        {
            Console.WriteLine("Product 1");
        }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    class Creator1 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product1();
        }
    }
    class Creator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product2();
        }
    }
}
