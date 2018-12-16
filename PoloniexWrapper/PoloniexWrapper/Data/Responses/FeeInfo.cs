﻿using Newtonsoft.Json;

using static System.Globalization.CultureInfo;
using static System.Globalization.NumberStyles;

namespace PoloniexWrapper.Data.Responses
{
    public class FeeInfo
    {        
        private readonly decimal makerFee;
        public decimal MakerFee { get => makerFee; }
        
        private readonly decimal takerFee;
        public decimal TakerFee { get => takerFee; }
        
        private readonly decimal thirtyDayVolume;
        public decimal ThirtyDayVolume { get => thirtyDayVolume; }
        
        private readonly decimal nextTier;
        public decimal NextTier { get => nextTier; }

        [JsonConstructor]
        public FeeInfo(string makerFee, string takerFee, string thirtyDayVolume, string nextTier)
        {
            decimal.TryParse(makerFee, Any, InvariantCulture, out this.makerFee);
            decimal.TryParse(takerFee, Any, InvariantCulture, out this.takerFee);
            decimal.TryParse(thirtyDayVolume, Any, InvariantCulture, out this.thirtyDayVolume);
            decimal.TryParse(nextTier, Any, InvariantCulture, out this.nextTier);
        }
    }
}
