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
            var now = DateTimeOffset.Now;
            var bidAsk1 = new BidAsk()
            {
                Ask = 1.0,
                Bid = 0.1,
                Id = "USDBTC",
                UnixTimeSec = now.ToUnixTimeSeconds()
            };

            var bidAsk2 = new BidAsk()
            {
                Ask = 1.0,
                Bid = 0.1,
                Id = "USDBTC",
                DateTime = now.UtcDateTime,
            };

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(bidAsk1));
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(bidAsk2));
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
