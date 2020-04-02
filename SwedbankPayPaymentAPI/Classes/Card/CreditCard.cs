using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;
using SwedbankPayPaymentAPI.Classes.Invoice;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class CreditCard
    {
        [JsonProperty("rejectCreditCards")]
        public bool RejectCreditCards { get; set; }
        
        [JsonProperty("rejectDebitCards")]
        public bool RejectDebitCards { get; set; }
        
        [JsonProperty("rejectConsumerCards")]
        public bool RejectConsumerCards { get; set; }
        
        [JsonProperty("rejectCorporateCards")]
        public bool RejectCorporateCards { get; set; }
        
        [JsonProperty("no3DSecure")]
        public bool No3DSecure { get; set; }

        public CreditCard()
        {
            RejectCreditCards = false;
            RejectDebitCards = false;
            RejectConsumerCards = false;
            RejectCorporateCards = false;
            No3DSecure = false;
        }
    }
    
    
}