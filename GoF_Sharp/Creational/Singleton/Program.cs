using System.Collections.Generic;

namespace Creational
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var a = Task.Run(() => { Thread.Sleep(1000); Console.Write("WTF"); });
            //Console.WriteLine("ayo");
            //a.Wait();
            //Console.WriteLine("UIUI");
            //return 10;
            
        }
    }
    public sealed class Singleton
    {
        static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton() { }
        Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

    //public sealed class Singleton
    //{
    //    static Singleton instance = null;
    //    static readonly object padlock = new object();

    //    Singleton()
    //    {
    //    }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            lock (padlock)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Singleton();
    //                }
    //                return instance;
    //            }
    //        }
    //    }
    //}
}
