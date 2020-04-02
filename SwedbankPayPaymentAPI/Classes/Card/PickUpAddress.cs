using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Invoice
{
    public class PickUpAddress
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
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