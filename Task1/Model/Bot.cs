using System;

namespace Task1.Model
{
    internal class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
        }

        public void OnSeeEnemy(Player player)
        {
            if (player.IsAlive)
                Fire(player);
        }

        public void Fire(Player player) => _weapon.Damage(player);
    }
}