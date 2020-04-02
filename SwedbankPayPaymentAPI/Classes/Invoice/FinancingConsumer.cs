using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Invoice
{
    public class FinancingConsumer
    {
        [JsonProperty("payment")]
        public InvoicePayment Payment { get; set; }
        [JsonProperty("invoice")]
        public Invoice Invoice { get; set; }
    }
}