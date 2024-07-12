using System.Collections;

public class DataImporter
{
    public void Import(object? o)
    {
        string? directory = o?.ToString();
    }
}
class Program
{
    private static void Main(string[] args)
    {
        //var importer = new DataImporter();
        //Task.Factory.StartNew(importer.Import, 2);
        Task[] arrayList = new Task[10];
        for (int i = 0; i < 10; i++)
        {
            int ii = i;
            var x = () => { Console.WriteLine(ii); };
            arrayList[i] = Task.Factory.StartNew(x);
            //(new Thread(new ThreadStart(() => { Thread.Sleep(10); Console.WriteLine(i);  }))).Start();
        }
        Task.WaitAll(arrayList);
    }
}