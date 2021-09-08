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

        public void TryDamage(float damage)
        {
            if (damage < 0f)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Value -= Convert.ToInt32(damage);

            if (Value <= 0)
                Value = 0;
        }
    }
}