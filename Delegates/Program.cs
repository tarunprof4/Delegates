using Serilog;
using System;

namespace Delegates
{
    class Program
    {
        private static void InitializeSerilog()
        {
            Log.Logger = new LoggerConfiguration()
         .MinimumLevel.Verbose()
         .WriteTo.File("log.txt")
         .CreateLogger();
        }
        static void Main(string[] args)
        {
            InitializeSerilog();

            DbInterceptor dbInterceptor = new DbInterceptor();
            var response1 = dbInterceptor.GetQueryResults("Saveid 1", () => Save1(1));
            var response2 = dbInterceptor.GetQueryResults("Saveid 2", () => Save2(2));
        }

        static string Save1(int id)
        {
            return ("Success saved id " + id);
        }

        static string Save2(int id)
        {
            return ("Success saved id " + id);
        }
    }
}
