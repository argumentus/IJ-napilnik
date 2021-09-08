using System;
using Task1.Model;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Game Start");

            Health healthPlayer = new Health(100);
            Player player = new Player(healthPlayer, 30f);

            Health healthBot = new Health(100);
            Weapon weaponBot = new Weapon(3.2f, 20, 3);
            Bot artas = new Bot(healthBot, weaponBot, 10.5f);

            do
            {
                player.OnSeeEnemy(artas);
                artas.OnSeeEnemy(player);
            } while (!player.Health.IsDead && !artas.Health.IsDead);

            Console.WriteLine("Game End");
        }
    }
}