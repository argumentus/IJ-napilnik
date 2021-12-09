using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Player : ICreature
    {
        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            Health = health;
        }

        public int Health { get; private set; }
        public bool IsAlive => Health > 0;

        public void TryDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            Health -= damage;

            if (Health <= 0)
                Health = 0;
        }
    }
}