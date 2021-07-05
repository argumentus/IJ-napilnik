using System;
using Task1.Model;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Game Start");

            Health healthPlayer = new Health(100, new NormalDyingPolicy());
            Player player = new Player("Player 1", healthPlayer, 30f);
            player.Health.OnDie += OnDieHandler;

            Health healthBot = new Health(100, new NormalDyingPolicy());
            Weapon weaponBot = new Weapon(3.2f, 20, 3);
            Bot artas = new Bot("Bot 1", healthBot, weaponBot, 10.5f);
            artas.Health.OnDie += OnDieHandler;

            do
            {
                player.OnSeeEnemy(artas);
                artas.OnSeeEnemy(player);
            } while (!player.Health.IsDead && !artas.Health.IsDead);

            Console.WriteLine("Game End");
        }

        private static void OnDieHandler(string name)
        {
            Console.WriteLine("{0} умер!", name);
        }
    }
}