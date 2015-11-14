using Newtonsoft.Json;

namespace FaceOffers
{
    public abstract class FaceOffersObject
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
    }
}
