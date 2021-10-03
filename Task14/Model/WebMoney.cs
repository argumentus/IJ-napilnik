using System;

namespace Task14.Model
{
    class WebMoney : PaySystem
    {
        public override string Name => "WebMoney";

        public override void Pay()
        {
            Console.WriteLine("Вызов API WebMoney...");
        }

        public override void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через WebMoney...");
        }
    }
}