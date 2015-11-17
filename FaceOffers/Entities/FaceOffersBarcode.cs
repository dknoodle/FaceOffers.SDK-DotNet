using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersBarcode
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Type")]
        public int? Type { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
