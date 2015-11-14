using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersMerchant : FaceOffersObject
    {
        [JsonProperty("PlanId")]
        public Guid? PlanId { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("UserId")]
        public string UserId { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }
}
