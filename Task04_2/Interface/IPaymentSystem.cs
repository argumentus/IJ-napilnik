using Task04_2.Model;

namespace Task04_2.Interface
{
    public interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}