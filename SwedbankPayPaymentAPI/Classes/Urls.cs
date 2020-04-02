using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes
{
    public class Urls
    {
        [JsonProperty("invoiceType")]
        public string CompleteUrl { get; set; }
        [JsonProperty("cancelUrl")]
        public string CancelUrl { get; set; }
        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        [JsonProperty("termsOfServiceUrl")]
        public string TermsOfServiceUrl { get; set; }
    }
}