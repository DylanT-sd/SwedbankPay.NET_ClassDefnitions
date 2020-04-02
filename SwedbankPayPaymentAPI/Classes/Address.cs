using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class Address
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("msisdn")]
        public string Msisdn { get; set; }
        
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }
        
        [JsonProperty("coAddress")]
        public string CoAddress { get; set; }
        
        [JsonProperty("city")]
        public string City { get; set; }
        
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }
        
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
        
    }
}