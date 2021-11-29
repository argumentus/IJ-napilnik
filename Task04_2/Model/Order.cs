using Task04_2.Enum;

namespace Task04_2.Model
{
    public class Order
    {
        public readonly int Id;
        public readonly int Amount;
        public readonly Currency Currency;

        public Order(int id, int amount, Currency currency) => (Id, Amount, Currency) = (id, amount, currency);
    }
}