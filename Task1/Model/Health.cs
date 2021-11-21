using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Health : IHealth, IDamageable
    {
        public int Value { get; private set; }

        public Health(int health)
        {
            Value = health;
        }

        public bool IsDead => Value <= 0;

        public void TryDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Value -= damage;

            if (Value <= 0)
                Value = 0;
        }
    }
}