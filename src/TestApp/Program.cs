using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MyJetWallet.Domain.Candles;
using Serilog;
using Serilog.Events;
using ILogger = Serilog.ILogger;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
        }
    }

    public class MyLogger: Serilog.ILogger
    {
        private readonly ILogger _logger;

        public MyLogger(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void Write(LogEvent logEvent)
        {
            _logger.Write(logEvent);
            Console.WriteLine("Hey from logger");
        }
    }
}
