using System;
using System.Collections.Generic;
using Task02.Interface;

namespace Task02.Model
{
    public class Cart : IViewGoods
    {
        private List<Product> _products = new List<Product>();
        private Warehouse _warehouse;
        public string Paylink { get; private set; }

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void Add(Good good, int count)
        {
            if (count < 1)
                return;

            if (!_warehouse.CanOrder(good, count))
                throw new ArgumentOutOfRangeException($"{nameof(count)} of {good.Name}");
            
            Product productInCart = Product.FindGoodInProducts(_products, good);
            
            if (productInCart == null)
                _products.Add(new Product(good, count));
            else
                productInCart.Count += count;
        }

        public Cart Order()
        {
            if (_warehouse.TryOrder(_products))
            {
                _products = new List<Product>();
                Paylink = UrlGenerator.PayLink();
            } else
                throw new ArgumentException(nameof(_products));

            return this;
        }
        
        public void ViewGoods()
        {
            Console.WriteLine("Товар в корзине:");
            GoodView.View(_products);
        }
        
    }
}