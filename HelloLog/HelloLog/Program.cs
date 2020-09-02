using System;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace HelloLog
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configSerilog = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", true, true)
               .Build();


            ILogger log = new LoggerConfiguration()
                 .ReadFrom.Configuration(configSerilog)
                          .CreateLogger();


            log.Information("Initializing Serilog....");



      /*            ILogger logToConsole = new LoggerConfiguration().WriteTo.Console().CreateLogger();
                        *//*ILogger logToFile = new LoggerConfiguration().WriteTo.File("log.txt", rollOnFileSizeLimit:true, fileSizeLimitBytes:1024).CreateLogger();
                        logToFile.Information("Hello Serilog");*/
        }
    }
}
