using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Health : IHealth, IDamageable
    {
        private IDyingPolicy _dyingPolicy;
        public int Value { get; private set; }
        public event Action<string> OnDie;

        public Health(int health, IDyingPolicy dyingPolicy)
        {
            Value = health;
            _dyingPolicy = dyingPolicy;
        }

        public bool IsDead => _dyingPolicy.IsDead(Value);

        public void TryDamage(float damage)
        {
            if (damage < 0f)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Value -= Convert.ToInt32(damage);

            if (Value <= 0)
                Value = 0;

            if (_dyingPolicy.IsDead(Value))
                OnDie?.Invoke("Name"); // TODO: Как правильно передать name или обработать event для вывода имени?
        }
    }
}