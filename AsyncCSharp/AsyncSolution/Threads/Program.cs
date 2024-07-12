using System.Collections;

class Program
{
    private static void Main()
    {
        //(new Thread(new ThreadStart(MonitorNetworkB))).Start();
        //Если так, то ниче не напечатается
        ThreadPool.QueueUserWorkItem(MonitorNetworkA);
    }
    static void MonitorNetworkA(object? a)
    {
        Console.WriteLine("123");
    }
    static void MonitorNetworkB()
    {
        Thread.Sleep(1000);
    }
}



//ArrayList lst = new ArrayList();
//for (int i = 0; i < 25; i++)
//{
//    var t = new Thread(new ThreadStart(MonitorNetwork));
//    lst.Add(t);
//    t.Start();
//    Console.WriteLine(i);
//}
//monitorThread.Start();
//if(monitorThread.Join(TimeSpan.FromSeconds(5)))
// {
//     Console.WriteLine("Ended within 5 sec");
// }
//Thread.Sleep(1000);

//Console.WriteLine("Hello after launch");
