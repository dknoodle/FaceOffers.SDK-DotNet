using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceOffers
{
    public class FaceOffersBarcode : FaceOffersObject
    {
        [JsonProperty("Type")]
        public int? Type { get; set; }

        [JsonProperty("Code")]
        public string Code { get; set; }
    }
}
