//using MailKit.Search;
//using System.Windows.Forms;


//class Program
//{
//    private IAsyncResult asyncCall;
//    private System.Timers.Timer asyncTimer;
//    private static void Main(string[] args)
//    {

//    }
    
//    private void OnPerformSearch(object sender, RoutedEventArgs e)
//    {
//        int dummy;
//        asyncCall = BeginGetResults(1, 50, out dummy, null, null);
//        asyncTimer = new System.Timers.Timer();
//        asyncTimer.Interval = 200;
//        asyncTimer.Elapsed += OnTimerTick;
//        asyncTimer.Start();
//    }
//    private void OnTimerTick(object sender, ElapsedEventArgs e)
//    {
//        if (asyncCall.IsCompleted)
//        {
//            int resultCount;
//            try
//            {
//                SearchResults results = EndGetResults(out resultCount, asyncCall);
//                DisplayResults(results, resultCount);
//            }
//            catch (Exception x)
//            {
//                LogError(x);
//            }
//            asyncTimer.Dispose();
//        }
//    }
//}
