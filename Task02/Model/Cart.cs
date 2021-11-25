using System;
using System.Collections.Generic;
using System.Linq;
using Task02.Interface;

namespace Task02.Model
{
    public class Cart
    {
        private List<Cell> _cells = new List<Cell>();
        private Warehouse _warehouse;
        public string Paylink { get; private set; }

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }
        
        public IReadOnlyList<IReadOnlyCell> Cells => _cells;
        
        public void Add(Product product, int count)
        {
            if (count < 1)
                throw new ArgumentException(nameof(count));

            if (!_warehouse.IsAvailableProduct(product, count))
                throw new ArgumentOutOfRangeException($"{nameof(count)} of {product.Name}");

            Cell productInCart = _cells.FirstOrDefault(p => p.Product.Name == product.Name);

            if (productInCart == null)
                _cells.Add(new Cell(product, count));
            else
                productInCart.Count += count;
        }

        public Cart Order()
        {
            if (!_warehouse.Ship(_cells))
                throw new InvalidCastException();
            
            Paylink = UrlGenerator.PayLink();

            return this;
        }

    }
}