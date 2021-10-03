using System;

namespace Task14.Model
{
    class Qiwi : PaySystem
    {
        public override string Name => "Qiwi";
            
        public override void Pay()
        {
            Console.WriteLine("Перевод на страницу QIWI...");
        }

        public override void CheckPayment()
        {
            Console.WriteLine("Проверка платежа через QIWI...");
        }
    }
}