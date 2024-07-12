using System.Net;

class Program
{
    public static void Main(string[] args)
    {
        LookupHostName();
    }
    private static void LookupHostName()
    {
        Task<IPAddress[]> ipAddressesPromise =
            Dns.GetHostAddressesAsync("oreilly.com");
        ipAddressesPromise.ContinueWith(_ =>
        {
            IPAddress[] ipAddresses = ipAddressesPromise.Result;
        });
        ipAddressesPromise.Start();
    }
}
//class Block
//{
//    public string BlockText = String.Empty;
//    public async void DumpWebPage(Uri uri)
//    {
//        var webClient = new HttpClient();
//        webClient. += OnDownloadStringCompleted;
//        await webClient.DownloadStringAsync(uri);
//    }
//    public void OnDownloadStringCompleted(object sender,
//     DownloadStringCompletedEventArgs eventArgs)
//    {

//        this.BlockText = eventArgs.Result;
//    }
//}