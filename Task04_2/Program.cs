using System;
using Task04_2.Enum;
using Task04_2.Model;
using Task04_2.Model.Cryptography;
using Task04_2.Model.Payment;

namespace Task04_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Выведите платёжные ссылки для трёх разных систем платежа: 
            // pay.system1.ru/order?amount=12000RUB&hash={MD5 хеш ID заказа}
            // order.system2.ru/pay?hash={MD5 хеш ID заказа + сумма заказа}
            // system3.com/pay?amount=12000&curency=RUB&hash={SHA-1 хеш сумма заказа + ID заказа + секретный ключ от системы}
            

            Order order = new Order(1, 12000, Currency.RUB);

            TinkoffPaymentSystem tinkoffPaymentSystem = new TinkoffPaymentSystem(
                new PaymentSystemSetting("https://pay.system1.ru", "/order"),
                new CryptographyAlgorithmMD5()
            );
            string tinkoffPaymentUrl = tinkoffPaymentSystem.GetPayingLink(order);
            Console.WriteLine(tinkoffPaymentUrl);
            
            AlfabankPaymentSystem alfabankPaymentSystem = new AlfabankPaymentSystem(
                new PaymentSystemSetting("https://order.system2.ru", "/pay"),
                new CryptographyAlgorithmMD5()
            );
            string alfabankPaymentUrl = alfabankPaymentSystem.GetPayingLink(order);
            Console.WriteLine(alfabankPaymentUrl);
            
            VTBPaymentSystem vtbPaymentSystem = new VTBPaymentSystem(
                new PaymentSystemSetting("https://system3.com", "/pay", "secretVtb"),
                new CryptographyAlgorithmSHA1()
            );
            string vtbPaymentUrl = vtbPaymentSystem.GetPayingLink(order);
            Console.WriteLine(vtbPaymentUrl);
        }
    }
    
}