using Task04_2.Interface;

namespace Task04_2.Model.Payment
{
    public abstract class PaymentSystem : IPaymentSystem, ICryptographyAlgorithm
    {
        private readonly ICryptographyAlgorithm _cryptographyAlgorithm;

        public PaymentSystem(ICryptographyAlgorithm cryptographyAlgorithm)
        {
            _cryptographyAlgorithm = cryptographyAlgorithm;
        }

        public abstract string GetPayingLink(Order order);

        public string Cryptography(string text)
        {
            return _cryptographyAlgorithm.Cryptography(text);
        }
    }
}