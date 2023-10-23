using System;
using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Candles;

[DataContract]
public class MyCandleModel
{
    [DataMember(Order = 1)]
    public long DateTime { get; set; }

    [DataMember(Order = 2)]
    public double Open { get; set; }

    [DataMember(Order = 3)]
    public double Close { get; set; }

    [DataMember(Order = 4)]
    public double High { get; set; }

    [DataMember(Order = 5)]
    public double Low { get; set; }

    [DataMember(Order = 6)]
    public double Volume { get; set; }
}