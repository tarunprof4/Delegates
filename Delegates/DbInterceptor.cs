using Serilog;
using System;
using System.Diagnostics;

namespace Delegates
{
    public class DbInterceptor
    {
        public T GetQueryResults<T>(string operationName, Func<T> retrieveValues)
        {

            Log.Information("operation {0} started", operationName);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var result = retrieveValues.Invoke();
            Log.Information("result {0}", result);
            stopWatch.Stop();

            Log.Information("operation {0} ended with total time {1}", operationName, stopWatch.Elapsed);

            return result;
        }
    }
}
