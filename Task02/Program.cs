using System;
using Task02.Interface;
using Task02.Model;

namespace Task02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product iPhone12 = new Product("IPhone 12");
            Product iPhone11 = new Product("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);

            //Вывод всех товаров на складе с их остатком
            ViewCell(warehouse.Cells);

            Cart cart = shop.Cart();
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе
            
            //Вывод всех товаров в корзине
            ViewCell(cart.Cells);
            
            // Paylink - просто какая-нибудь случайная строка.
            Console.WriteLine(cart.Order().Paylink);
            
            cart.Add(iPhone12, 9); //Ошибка, после заказа со склада убираются заказанные товары
        }
        
        public static void ViewCell(Cells cells)
        {
            if (cells != null && cells.Count > 0)
            {
                foreach (IReadOnlyCell cell in cells)
                {
                    Console.WriteLine($"Товар: {cell.Product.Name}, остаток:  {cell.Count}");
                }
            }
        }
    }
}