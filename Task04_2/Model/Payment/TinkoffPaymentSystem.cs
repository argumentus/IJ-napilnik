using System.Collections.Generic;
using Task04_2.Interface;
using Task04_2.Model.Web;

namespace Task04_2.Model.Payment
{
    public class TinkoffPaymentSystem : PaymentSystem
    {
        private readonly PaymentSystemSetting _paymentSystemSetting;

        public TinkoffPaymentSystem(PaymentSystemSetting paymentSystemSetting, ICryptographyAlgorithm cryptographyAlgorithm) :
            base(cryptographyAlgorithm)
        {
            _paymentSystemSetting = paymentSystemSetting;
        }

        public override string GetPayingLink(Order order)
        {
            Dictionary<string, string> queries = new Dictionary<string, string>();
            queries.Add("amount", order.Amount.ToString() + order.Currency.ToString());
            queries.Add("hash", Cryptography(order.Id.ToString()));

            WebUrl webUrl = new WebUrl(_paymentSystemSetting.Host, _paymentSystemSetting.PathPay, queries);

            return webUrl.CreateUrl();
        }
    }
}