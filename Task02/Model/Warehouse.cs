using System;
using System.Collections.Generic;
using Task02.Interface;

namespace Task02.Model
{
    public class Warehouse : IViewGoods
    {
        private readonly List<Product> _products = new List<Product>();
        
        public void Delive(Good good, int count)
        {
            if (count < 1)
                return;

            Product productInWarehouse = Product.FindGoodInProducts(_products, good);

            if (productInWarehouse == null)
                _products.Add(new Product(good, count));
            else
                productInWarehouse.Count += count;
        }
        
        public bool TryOrder(List<Product> products)
        {
            if (!CanOrder(products))
                return false;
            
            if (products.Count > 0)
            {
                foreach (Product product in products)
                {
                    if (CanOrder(product.Good, product.Count))
                    {
                        Product productInWarehouse = Product.FindGoodInProducts(_products, product.Good);
                        if (productInWarehouse != null)
                            productInWarehouse.Count -= product.Count;
                    } else 
                        return false;
                }
            } else 
                return false;
            
            return true;
        }

        public bool CanOrder(List<Product> products)
        {
            if (products.Count > 0)
            {
                foreach (Product product in products)
                {
                    if (!CanOrder(product.Good, product.Count))
                        return false;
                }
            } else 
                return false;
            
            return true;
        }

        public bool CanOrder(Good good, int count)
        {
            Product productInWarehouse = Product.FindGoodInProducts(_products, good);

            return productInWarehouse != null && productInWarehouse.Count >= count;
        }
        
        public void ViewGoods()
        {
            Console.WriteLine("Товар на складе:");
            GoodView.View(_products);
        }

    }
}