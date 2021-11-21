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
            Player player = new Player(healthPlayer, 30);

            Health healthBot = new Health(100);
            Weapon weaponBot = new Weapon(3, 20, 3);
            Bot artas = new Bot(healthBot, weaponBot, 10);

            do
            {
                player.OnSeeEnemy(artas);
                artas.OnSeeEnemy(player);
            } while (player.IsAlive && artas.IsAlive);

            Console.WriteLine("Game End");
        }
    }
}