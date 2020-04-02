using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class PayeeInfo
    {
        [JsonProperty("payeeId")]
        public string PayeeId { get; set; }
        [JsonProperty("payeeReference")]
        public string PayeeReference { get; set; }
        [JsonProperty("payeeName")]
        public string PayeeName { get; set; }
        [JsonProperty("productCategory")]
        public string ProductCategory { get; set; }
        [JsonProperty("subsite")]
        public string Subsite { get; set; }
    }
}