﻿
namespace Creational
{
    class Program
    {
        public void Main()
        {
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
    class SubsystemA
    {
        public void A1()
        { }
    }
    class SubsystemB
    {
        public void B1()
        { }
    }
    class SubsystemC
    {
        public void C1()
        { }
    }

    class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;

        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }

    
}