namespace Task04_2.Model.Payment
{
    public class PaymentSystemSetting
    {
        public string Host { get; }
        public string PathPay { get; }
        public string SecretKey { get; }

        public PaymentSystemSetting(string host, string pathPay, string secretKey = default) =>
            (Host, PathPay, SecretKey) = (host, pathPay, secretKey);
    }
}