using System;
using System.Collections.Generic;

namespace Task02.Model
{
    public static class GoodView
    {
        public static void View(List<Product> products)
        {
            if (products.Count > 0)
            {
                foreach (Product product in products)
                {
                    Console.WriteLine($"Товар: {product.Good.Name}, остаток:  {product.Count}");
                }
            } else
                Console.WriteLine("Товаров нет.");
        }
    }
}