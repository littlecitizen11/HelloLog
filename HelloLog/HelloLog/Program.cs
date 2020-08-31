using System;
using Serilog;

namespace HelloLog
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger log = new LoggerConfiguration().WriteTo.File("log.txt", rollingInterval: RollingInterval.Day).CreateLogger();
            log.Information("Hello Serilog");
        }
    }
}
