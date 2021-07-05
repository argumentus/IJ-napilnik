using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Player : ICreature
    {
        private readonly Health _health;
        private float _damage;
        public string Name { get; }

        public Player(string name, Health health, float damage)
        {
            if (health == null)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            Name = name;
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