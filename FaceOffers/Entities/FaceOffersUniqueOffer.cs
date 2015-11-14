using FaceOffers.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersUniqueOffer : FaceOffersObject
    {
        [JsonProperty("OfferId")]
        public Guid? OfferId { get; set; }

        [JsonProperty("ConsumerId")]
        public Guid? ConsumerId { get; set; }

        [JsonProperty("BarcodeId")]
        public Guid? BarcodeId { get; set; }

        [JsonProperty("Discount")]
        public string Discount { get; set; }

        [JsonProperty("ShareDiscount")]
        public string ShareDiscount { get; set; }

        [JsonProperty("RedeemDiscount")]
        public string RedeemDiscount { get; set; }

        [JsonProperty("Timestamp")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime? Timestamp { get; set; }
    }
}
