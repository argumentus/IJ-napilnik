using System.Collections.Generic;
using System.Linq;

namespace Task02.Model
{
    public class Product
    {
        public Good Good;
        public int Count;

        public Product(Good good, int count)
        {
            Good = good;
            Count = count;
        }

        public static Product FindGoodInProducts(List<Product> products, Good good)
        {
            return products.FirstOrDefault(p => p.Good.Name == good.Name);
        }
    }
}