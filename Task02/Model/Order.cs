using System;

namespace Task02.Model
{
    public class Order
    {
        private readonly Warehouse _warehouse;
        public Order(Warehouse warehouse) => _warehouse = warehouse;
        public string Paylink { get; private set; }
        
        public Order Create(Cells cells)
        {
            if (!_warehouse.Ship(cells))
                throw new InvalidOperationException();
            
            Paylink = UrlGenerator.PayLink();
            
            return this;
        }
    }
}