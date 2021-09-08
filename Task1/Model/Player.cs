using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Player : ICreature, IDamageable
    {
        private readonly Health _health;
        private float _damage;

        public Player(Health health, float damage)
        {
            if (health == null)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            _health = health;
            _damage = damage;
        }

        public IHealth Health => _health;

        public void TryDamage(float damage)
        {
            _health.TryDamage(damage);
        }

        public void OnSeeEnemy(ICreature enemy)
        {
            enemy.TryDamage(_damage);
        }
    }
}