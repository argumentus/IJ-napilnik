namespace Task02.Model
{
    public class Shop
    {
        readonly Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public Cart Cart() => new Cart(_warehouse);
    }
}