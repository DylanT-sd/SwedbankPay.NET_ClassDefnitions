using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class Operation
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }
}