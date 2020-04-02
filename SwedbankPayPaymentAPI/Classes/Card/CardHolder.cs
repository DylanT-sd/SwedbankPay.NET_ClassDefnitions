using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class CardHolder
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set)
        /// Mobile station isdn number, For GSM use Mobile number with countrycode + (E.g : +46 for Sweden)
        /// </summary>
        [JsonProperty("msisdn")]
        public string Msisdn { get; set; }
        
        [JsonProperty("homePhoneNumber")]
        public string HomePhoneNumber { get; set; }
        
        [JsonProperty("workPhoneNumber")]
        public string WorkPhoneNumber { get; set; }
        
        [JsonProperty("shippingAddress")]
        public Address ShippingAddress { get; set; }
        
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }
        
        [JsonProperty("accountInfo")]
        public AccountInfo AccountInfo { get; set; }
        
    }
}