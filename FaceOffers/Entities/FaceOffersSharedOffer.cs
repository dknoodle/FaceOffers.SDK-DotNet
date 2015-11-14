using FaceOffers.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersSharedOffer : FaceOffersObject
    {
        [JsonProperty("FromConsumerId")]
        public Guid? FromConsumerId { get; set; }

        [JsonProperty("ToConsumerId")]
        public Guid? ToConsumerId { get; set; }

        [JsonProperty("OfferId")]
        public Guid OfferId { get; set; }

        [JsonProperty("Redeemed")]
        public bool? Redeemed { get; set; }

        [JsonProperty("Timestamp")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}
