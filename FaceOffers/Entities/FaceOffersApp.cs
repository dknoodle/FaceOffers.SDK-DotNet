using FaceOffers.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersApp : FaceOffersObject
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Created")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("Modified")]
        [JsonConverter(typeof(FaceOffersDateTimeConverter))]
        public DateTime? Modified { get; set; }

        [JsonProperty("Photo")]
        public string Photo { get; set; }

        [JsonProperty("KeyId")]
        public Guid KeyId { get; set; }
    }
}
