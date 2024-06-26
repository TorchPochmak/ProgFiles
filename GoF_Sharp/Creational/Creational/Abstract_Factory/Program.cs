//Abstract Factory

namespace Creational
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(new ColaFactory());
            client.Run();
            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
    #region WaterAndBottle
    abstract class AbstractWater 
    {
        public abstract string Name { get; set; } 
    }
    class ColaWater : AbstractWater
    {
        public override string Name { get; set; } = "Cola";
    }
    class PepsiWater : AbstractWater 
    {
        public override string Name { get; set; } = "Pepsi";
    }

    abstract class AbstractBottle 
    {
        public abstract void WriteInfo(AbstractWater water);
    }
    class CoffeeBottle : AbstractBottle 
    {
        public override void WriteInfo(AbstractWater water)
        {
            Console.WriteLine(water.Name + " in coffee bottle");
        }
    }
    class PlasticBottle : AbstractBottle 
    {
        public override void WriteInfo(AbstractWater water)
        {
            Console.WriteLine(water.Name + " in plastic bottle");
        }
    }
    #endregion

    #region Factories
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
    }
    class ColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle() { return new CoffeeBottle(); }
        public override AbstractWater CreateWater() { return new ColaWater(); }
    }
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle() { return new PlasticBottle(); }
        public override AbstractWater CreateWater() { return new PepsiWater(); }
    }
    #endregion

    class Client
    {
        private AbstractBottle _bottle;
        private AbstractWater _water;

        public Client(AbstractFactory factory)
        {
            _water = factory.CreateWater();
            _bottle = factory.CreateBottle();
        }
        public void Run()
        {
            _bottle.WriteInfo(_water);
        }
    }
}
