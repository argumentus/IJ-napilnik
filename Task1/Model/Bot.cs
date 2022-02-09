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

        public void TryFire(Player player)
        {
            _weapon?.TryFire(player);
        }
    }
}