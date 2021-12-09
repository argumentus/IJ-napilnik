using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void OnSeeEnemy(Player player)
        {
            if (player.IsAlive)
                TryFire(player);
        }

        public bool CanFire()
        {
            return _weapon != null && _weapon.CanFire();
        }
        
        public void TryFire(Player player)
        {
            if (!CanFire())
                throw new ArgumentException(nameof(CanFire));
            
            _weapon.TryFire(player);
        }

    }
}