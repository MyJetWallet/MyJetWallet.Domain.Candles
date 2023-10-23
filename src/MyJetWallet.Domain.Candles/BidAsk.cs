using System;
using System.Runtime.Serialization;
using DotNetCoreDecorators;

namespace MyJetWallet.Domain.Candles
{
    [DataContract]
    public class BidAsk
    {
        public const string TopicName = "spot-bidask";
        
        private long _unixTimeSec;

        [DataMember(Order = 1)]
        public string Id { get; set; }

        [Obsolete]
        [DataMember(Order = 2)]
        public DateTime DateTime
        {
            get => TimeFromLong(_unixTimeSec);
            set => _unixTimeSec = TimeToLong(value);
        }

        [DataMember(Order = 3)]
        public double Bid { get; set; }

        [DataMember(Order = 4)]
        public double Ask { get; set; }

        [DataMember(Order = 6)]
        public long UnixTime
        {
            get => _unixTimeSec;
            set => _unixTimeSec = value;
        }
        
        [DataMember(Order = 7)]
        public double Last { get; set; }

        public static DateTime TimeFromLong(long ts) => ts.UnixTimeToDateTime();
        public static long TimeToLong(DateTime ts) => ts.UnixTime();
    }
}
