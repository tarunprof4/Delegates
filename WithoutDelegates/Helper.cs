using Serilog;
using System.Diagnostics;

namespace WithoutDelegates
{
    public class Helper<T>
    {
        public Stopwatch PreOperation(string operationName)
        {
            Log.Information("operation {0} started", operationName);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            return stopWatch;
        }

        public void PostOperation(string operationName, Stopwatch stopwatch, T result)
        {
            stopwatch.Stop();

            Log.Information("result {0}", result);
            Log.Information("operation {0} ended with total time {1}", operationName, stopwatch.Elapsed);
        }
    }
}
