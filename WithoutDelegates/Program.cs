using Serilog;
using System;

namespace WithoutDelegates
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

            var response1 = Save1(1);
            var response2 = Save2(2);
        }


        static string Save1(int id)
        {
            Helper<string> helper = new Helper<string>();
            var operationName = "Saveid 1";
            var stopwatch = helper.PreOperation(operationName);
            var response = ("Success saved id " + id);
            helper.PostOperation(operationName, stopwatch, response);
            return response;
        }

        static string Save2(int id)
        {
            Helper<string> helper = new Helper<string>();
            var operationName = "Saveid 2";
            var stopwatch = helper.PreOperation(operationName);
            var response = ("Success saved id " + id);
            helper.PostOperation(operationName, stopwatch, response);
            return response;
        }
    }
}
