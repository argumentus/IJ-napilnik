using System.Collections.Generic;
using Task04_2.Interface;
using Task04_2.Model.Web;

namespace Task04_2.Model.Payment
{
    public class VTBPaymentSystem : PaymentSystem
    {
        private readonly PaymentSystemSetting _paymentSystemSetting;

        public VTBPaymentSystem(PaymentSystemSetting paymentSystemSetting, ICryptographyAlgorithm cryptographyAlgorithm) :
            base(cryptographyAlgorithm)
        {
            _paymentSystemSetting = paymentSystemSetting;
        }

        public override string GetPayingLink(Order order)
        {
            Dictionary<string, string> queries = new Dictionary<string, string>();
            queries.Add("amount", order.Amount.ToString());
            queries.Add("currency", order.Currency.ToString());
            queries.Add("hash", Cryptography(order.Amount.ToString() + order.Id.ToString() + _paymentSystemSetting.SecretKey));

            WebUrl webUrl = new WebUrl(_paymentSystemSetting.Host, _paymentSystemSetting.PathPay, queries);

            return webUrl.CreateUrl();
        }
    }
}