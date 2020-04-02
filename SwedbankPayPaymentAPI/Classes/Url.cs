using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class Url
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}