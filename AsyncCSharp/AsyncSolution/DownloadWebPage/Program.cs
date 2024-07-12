using System.Net;

class Program
{
    private static void Main(string[] args)
    {
        Task<string> downloadTask = DownloadWebPageAsync(@"https://github.com/");
        while (!downloadTask.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(100);
        }
        Console.WriteLine(downloadTask.Result);
    }
    private static Task<string> DownloadWebPageAsync(string url)
    {
        return Task.Factory.StartNew(() => DownloadWebPage(url));
    }
    private static string DownloadWebPage(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());
        {
            // this will return the content of the web page
            return reader.ReadToEnd();
        }
    }
    private static Task<string> BetterDownloadWebPageAsync(string url)
    {
        WebRequest request = WebRequest.Create(url);
        IAsyncResult ar = request.BeginGetResponse(null, null);
        Task<string> downloadTask =
        Task.Factory
        .FromAsync<string>(ar, iar =>
        {
            using (WebResponse response = request.EndGetResponse(iar))
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
        });
        return downloadTask;
    }
}