using System.Collections.Generic;
namespace Creational
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? a = null; //String
            if(a != null) go(a);

            int i = 0;
            int? ii = 56;//Nullable<Int32>
            //CONVENTION ALERT!
            Nullable<int> j = 0;

            if(j != null && ii != null)
                Console.WriteLine(j.GetType() == ii.GetType());
            Builder builder = new GoodButFucked();
            Director director = new Director(builder);
            director.Construct();
            Product f = director.Show();
            foreach(var x in f.Parts)
            {
                Console.WriteLine(x);
            }

        }
        public static void go(string s) { }
    }
    abstract class Builder
    {
        protected Product _product;
        public abstract Product GetProduct();
        public abstract Builder BuildA();
        public abstract Builder BuildB();
        public abstract Builder BuildC();
    }
    class Director
    {
        private Builder _builder;
        public Director(Builder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
            _builder.BuildA().BuildB().BuildC();
        }
        public Product Show()
        {
            return _builder.GetProduct();
        }
    }
    class Product
    {
        public List<string> Parts { get; private set; } = new List<string>();

        public void Add(string part)
        {
            Parts.Add(part);
        }
    }
    //abstract roof
    class GoodBuilder : Builder
    {
        public GoodBuilder()
        {
            _product = new Product();
        }
        public override Builder BuildA()//roof a
        {
            _product.Add("Part A");
            return this;
        }
        public override Builder BuildB()
        {
            _product.Add("Part B");
            return this;
        }
        public override Builder BuildC()
        {
            _product.Add("Part C");
            return this;
        }
        public override Product GetProduct()
        {
            return _product;
        }
    }
    class GoodButFucked : GoodBuilder
    {
        public override Builder BuildA()
        {
            _product.Add("Part A YOOOO");
            return this;
        }
    }
}
