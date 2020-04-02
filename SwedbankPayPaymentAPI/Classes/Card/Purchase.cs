using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class Purchase
    {
        [JsonProperty("cardHolder")]
        public CardPayment Payment { get; set; }
        
        [JsonProperty("creditCard")]
        public CreditCard CreditCard { get; set; }

        public Purchase()
        {
            CreditCard = new CreditCard();
        }
    }
}