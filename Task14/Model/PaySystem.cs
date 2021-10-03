using System;

namespace Task14.Model
{
    public abstract class PaySystem
    {
        public const string QiwiSystem = "Qiwi";
        public const string WebMoneySystem = "WebMoney";
        public const string CardSystem = "Card";
        public virtual string Name { get; private set; }  //property
        abstract public void Pay();
        abstract public void CheckPayment();

        public static PaySystem Create(string systemId)
        {
            switch (systemId)
            {
                case QiwiSystem:
                    return new Qiwi();
                case WebMoneySystem:
                    return new WebMoney();
                case CardSystem:
                    return new Card();
                    
                default:
                    throw new ArgumentException(nameof(systemId));
            }
        }
    }
}