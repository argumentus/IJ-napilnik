using System;

namespace Task14.Model
{
    class Card : PaySystem
    {
        public override string Name => "Card";

        public override void Pay()
        {
            Console.WriteLine("Вызов API банка эмитера карты Card...");
        }

        public override void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через Card...");
        }
    }
}