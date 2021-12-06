using System;

namespace Task02.Model
{
    public class Cart
    {
        public Cells Cells = new Cells();
        private Warehouse _warehouse;

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void Add(Product product, int count)
        {
            if (!_warehouse.IsAvailableProduct(product, count))
                throw new ArgumentOutOfRangeException($"{nameof(count)} of {product.Name}");

            Cells.Add(product, count);
        }

        public Order Order()
        {
            Order order = new Order(_warehouse);
            order.Create(Cells);

            return order;
        }

    }
}