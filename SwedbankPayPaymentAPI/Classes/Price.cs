using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class Price
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        

        [JsonProperty("amount")]
        public int Amount { get; set; }
        

        [JsonProperty("vatAmount")]
        public int VATAmount { get; set; }
    }
}