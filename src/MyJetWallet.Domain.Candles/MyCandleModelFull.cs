using System.Runtime.Serialization;

namespace MyJetWallet.Domain.Candles;

[DataContract]
public class MyCandleModelFull
{
    [DataMember(Order = 1)] public string Symbol { get; set; }
    [DataMember(Order = 2)] public MyCandleType Type { get; set; }
    [DataMember(Order = 3)] public MyCandleModel Candle { get; set; }

    public static MyCandleModelFull Create(string symbol, MyCandleType type, MyCandleModel candle)
    {
        return new MyCandleModelFull()
        {
            Symbol = symbol,
            Type = type,
            Candle = candle
        };
    }
}