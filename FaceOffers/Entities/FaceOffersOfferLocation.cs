using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersOfferLocation : FaceOffersObject
    {
        [JsonProperty("OfferId")]
        public Guid? OfferId { get; set; }

        [JsonProperty("MerchantLocationId")]
        public Guid? MerchantLocationId { get; set; }
    }
}
