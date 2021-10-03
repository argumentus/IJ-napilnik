using System;
using System.Collections.Generic;
using Task14.Model;

namespace Task14
{
    internal class Program
    {
        // Сейчас система не готова к расширению. К сожалению при добавление нового способа оплаты, нам нужно
        // модифицировать все ифы которые совершают те или иные действия с разными системами.

        // Необходимо зафиксировать интерфейс платежёной системы и сокрыть их многообразие под какой-нибудь сущностью.
        // Например фабрикой (или фабричным методом).

        // Важное условие: пользователь вводит именно идентификатор платёжной системы.

        // https://gist.github.com/HolyMonkey/14f78ed72bda289980fce43f50143278
        
        
        public class OrderForm
        {
            public string ShowForm()
            {
                Console.WriteLine("Мы принимаем: QIWI, WebMoney, Card");

                //симуляция веб интерфейса
                Console.WriteLine("Какое системой вы хотите совершить оплату?");
                return Console.ReadLine();
            }
        }

        public class PaymentHandler
        {
            public void ShowPaymentResult(PaySystem paySystem)
            {
                Console.WriteLine($"Вы оплатили с помощью {paySystem.Name}");

                paySystem.CheckPayment();

                Console.WriteLine("Оплата прошла успешно!");
            }
        }

        public static void Main(string[] args)
        {
            var orderForm = new OrderForm();
            var paymentHandler = new PaymentHandler();

            var systemId = orderForm.ShowForm();
            
            PaySystem paySystem = PaySystem.Create(systemId);
            paySystem.Pay();

            paymentHandler.ShowPaymentResult(paySystem);
        }
    }
}