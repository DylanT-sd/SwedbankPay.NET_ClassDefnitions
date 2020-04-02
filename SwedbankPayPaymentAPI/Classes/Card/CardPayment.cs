using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;
using SwedbankPayPaymentAPI.Classes.Invoice;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class CardPayment : Payment
    {
        [JsonProperty("cardHolder")]
        public PayeeInfo CardHolder { get; set; }
        
        [JsonProperty("paymentToken")]
        public string PaymentToken { get; set; }
        
        [JsonProperty("generatePaymentToken")]
        public bool GeneratePaymentToken { get; set; }
        
        [JsonProperty("riskIndicator")]
        public RiskIndicator RiskIndicator { get; set; }
        
        [JsonProperty("metadata")]
        public NameValueCollection MetaData { get; set; }
    }
}