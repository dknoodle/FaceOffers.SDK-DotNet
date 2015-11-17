using FaceOffers.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaceOffers
{
    public class FaceOffersAppClaim
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("AppId")]
        public Guid AppId { get; set; }

        [JsonProperty("Expires")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime Expires { get; set; }

        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("Revoked")]
        public bool Revoked { get; set; }
    }
}
