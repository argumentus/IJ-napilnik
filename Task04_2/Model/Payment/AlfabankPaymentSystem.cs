using System.Collections.Generic;
using Task04_2.Interface;
using Task04_2.Model.Web;

namespace Task04_2.Model.Payment
{
    public class AlfabankPaymentSystem : PaymentSystem
    {
        private readonly PaymentSystemSetting _paymentSystemSetting;

        public AlfabankPaymentSystem(PaymentSystemSetting paymentSystemSetting, ICryptographyAlgorithm cryptographyAlgorithm) :
            base(cryptographyAlgorithm)
        {
            _paymentSystemSetting = paymentSystemSetting;
        }

        public override string GetPayingLink(Order order)
        {
            Dictionary<string, string> queries = new Dictionary<string, string>();
            queries.Add("hash", Cryptography(order.Id.ToString() + order.Amount.ToString()));

            WebUrl webUrl = new WebUrl(_paymentSystemSetting.Host, _paymentSystemSetting.PathPay, queries);

            return webUrl.CreateUrl();
        }
    }
    
}