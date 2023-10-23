using System;
using System.Runtime.Serialization;

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

        [DataMember(Order = 5)]
        public long UnixTimeSec
        {
            get => _unixTimeSec;
            set => _unixTimeSec = value;
        }

        public static DateTime TimeFromLong(long ts) => DateTimeOffset.FromUnixTimeSeconds(ts).UtcDateTime;
        public static long TimeToLong(DateTime ts) => ((DateTimeOffset)ts).ToUnixTimeSeconds();
    }
}
