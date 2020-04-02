using Newtonsoft.Json;

namespace SwedbankPayPaymentAPI.Classes.Card
{
    public class AccountInfo
    {
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Indicates the length of time that the payments account was enrolled in the cardholder’s account with merchant.
        /// 01 (No account, guest)
        /// 02 (Created during transaction)
        /// 03 (Less than 30 days)
        /// 04 (30-60 days)
        /// 05 (More than 60 days)
        /// </summary>
        [JsonProperty("accountAgeIndicator")]
        public string AccountAgeIndicator { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Length of time since the cardholder’s account information with the merchant was changed. Including billing etc.
        /// 01 (Changed during transaction)
        /// 02 (Less than 30 days)
        /// 03 (30-60 days)
        /// 04 (More than 60 days)
        /// </summary>
        [JsonProperty("accountChangeIndicator")]
        public string AccountChangeIndicator { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Indicates the length of time since the cardholder’s account with the merchant had a password change or account reset.
        /// 01 (No change)
        /// 02 (Changed during transaction)
        /// 03 (Less than 30 days)
        /// 04 (30-60 days)
        /// 05 (More than 60 days)
        /// </summary>
        [JsonProperty("accountPwdChangeIndicator")]
        public string AccountPwdChangeIndicator { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Indicates when the shipping address used for this transaction was first used with the merchant.
        /// 01 (This transaction)
        /// 02 (Less than 30 days)
        /// 03 (30-60 days)
        /// 04 (More than 60 days)
        /// </summary>
        [JsonProperty("shippingAddressUsageIndicator")]
        public string ShippingAddressUsageIndicator { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.
        /// 01 (Account name identical to shipping name)
        /// 02 (Account name different than shipping name)
        /// </summary>
        [JsonProperty("shippingNameIndicator")]
        public string ShippingNameIndicator { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set).
        /// 
        /// Indicates whether merchant has experienced suspicious activity (including previous fraud) on the cardholder account.
        /// 01 (No suspicious activity has been observed)
        /// 02 (Suspicious activity has been observed)
        /// </summary>
        [JsonProperty("suspiciousAccountActivity")]
        public string SuspiciousAccountActivity { get; set; }
        
        /// <summary>
        /// Optional (increased chance for frictionless flow if set)
        /// 
        /// Allows the 3-D Secure Requestor to indicate to the ACS whether the cardholder’s billing and shipping address are the same.
        /// </summary>
        [JsonProperty("addressMatchIndicator")]
        public string AddressMatchIndicator { get; set; }
    }
}