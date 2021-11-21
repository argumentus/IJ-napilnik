using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Player : IDamageable, IAlive
    {
        private readonly Health _health;
        private int _damage;

        public Player(Health health, int damage)
        {
            if (health == null)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            _health = health;
            _damage = damage;
        }

        public bool IsAlive => !_health.IsDead;

        public void TryDamage(int damage)
        {
            _health.TryDamage(damage);
        }

        public void OnSeeEnemy(Bot bot)
        {
            bot.TryDamage(_damage);
        }
    }
}