using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Bot : IDamageable, IAlive
    {
        private readonly Health _health;
        private readonly Weapon _weapon;
        private int _strength;

        public Bot(Health health, Weapon weapon, int strength)
        {
            if (health == null)
                throw new ArgumentOutOfRangeException(nameof(health));
            
            _health = health;
            _weapon = weapon;
            _strength = strength;
        }

        public bool IsAlive => !_health.IsDead;

        public void TryDamage(int damage)
        {
            _health.TryDamage(damage);
        }

        public void OnSeeEnemy(Player player)
        {
            if (player.IsAlive)
                TryFire(player);
        }

        public bool CanFire()
        {
            return _weapon != null;
        }
        
        public void TryFire(Player player)
        {
            if (!CanFire())
                throw new ArgumentException(nameof(CanFire));
            
            if (_weapon.CanFire())
                _weapon.TryFire(player, CalculateDamage());
        }

        private int CalculateDamage()
        {
            return _strength * 2;
        }
    }
}