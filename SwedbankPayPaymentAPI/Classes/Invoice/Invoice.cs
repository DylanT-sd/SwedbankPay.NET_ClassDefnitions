using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Invoice
{
    public class Invoice
    {
        [JsonProperty("invoiceType")]
        public string InvoiceType;
    }
}