using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Candles
{
    [DataContract]
    public class BidAsk
    {
        public const string TopicName = "spot-bidask";

        [DataMember(Order = 1)]
        public string Id { get; set; }
        
        [DataMember(Order = 2)]
        public DateTime DateTime { get; set; }

        [DataMember(Order = 3)]
        public double Bid { get; set; }

        [DataMember(Order = 4)]
        public double Ask { get; set; }
        
        [DataMember(Order = 6)]
        public decimal Last { get; set; }

    }
}
