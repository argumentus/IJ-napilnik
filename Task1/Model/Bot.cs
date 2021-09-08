using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Bot : ICreature, IDamageable
    {
        private readonly Health _health;
        private readonly Weapon _weapon;
        private float _strength;

        public Bot(Health health, Weapon weapon, float strength)
        {
            if (health == null)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            _health = health;
            _weapon = weapon;
            _strength = strength;
        }

        public IHealth Health => _health;

        public void TryDamage(float damage)
        {
            _health.TryDamage(damage);
        }

        public void OnSeeEnemy(ICreature enemy)
        {
            float damage = _strength * 2;

            if (!enemy.Health.IsDead)
            {
                _weapon?.TryFire(enemy, damage);
            }
        }
    }
}