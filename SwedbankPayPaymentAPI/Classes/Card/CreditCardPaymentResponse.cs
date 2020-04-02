using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class CreditCardPaymentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("number")]
        public int Number { get; set; }
        
        [JsonProperty("instrument")]
        public string Instrument { get; set; }
        
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }
        
        [JsonProperty("operation")]
        public string Operation { get; set; }
        
        [JsonProperty("intent")]
        public string Intent { get; set; }
        
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        [JsonProperty("amount")]
        public string Amount { get; set; }
        
        [JsonProperty("remainingCaptureAmount")]
        public string RemainingCaptureAmount { get; set; }
        
        [JsonProperty("remainingCancellationAmount")]
        public string RemainingCancellationAmount { get; set; }
        
        [JsonProperty("remainingReversalAmount")]
        public string RemainingReversalAmount { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("payerReference")]
        public string PayerReference { get; set; }
        
        [JsonProperty("initiatingSystemUserAgent")]
        public string InitiatingSystemUserAgent { get; set; }
        
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
        
        [JsonProperty("language")]
        public string Language { get; set; }
        
        [JsonProperty("prices")]
        public Url Prices { get; set; }
        
        [JsonProperty("transactions")]
        public Url Transactions { get; set; }
        
        [JsonProperty("authorizations")]
        public Url Authorizations { get; set; }
        
        [JsonProperty("captures")]
        public Url Captures { get; set; }
        
        [JsonProperty("reversals")]
        public Url Reversals { get; set; }
        
        [JsonProperty("cancellations")]
        public Url Cancellations { get; set; }
        
        [JsonProperty("urls")]
        public Url Urls { get; set; }
        
        [JsonProperty("payeeInfo")]
        public Url PayeeInfo { get; set; }
        
        [JsonProperty("settings")]
        public Url Settings { get; set; }
        
        [JsonProperty("operations")]
        public List<Operation> Operations { get; set; }
        
    }
}