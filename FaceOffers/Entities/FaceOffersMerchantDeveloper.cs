using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersMerchantDeveloper : FaceOffersObject
    {
        [JsonProperty("MerchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }
    }
}
