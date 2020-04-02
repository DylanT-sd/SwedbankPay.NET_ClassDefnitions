using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class Payment
    {
        [JsonProperty("Operation")]
        public string Operation { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("prices")]
        public List<Price> Prices { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("payerReference")]
        public string PayerReference { get; set; }

        [JsonProperty("generateRecurrenceToken")]
        public string GenerateRecurrenceToken { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// nb-NO, sv-SE or en-US
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("payeeInfo")]
        public PayeeInfo PayeeInfo { get; set; }
    }
}