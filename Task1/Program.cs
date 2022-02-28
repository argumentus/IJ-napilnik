using System;
using Task1.Model;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Боты ходят по карте и когда видят игрока стреляют в него.
            // Систему обнаружения игрока оставим за кадром и ограничимся публичным методом OnSeePlayer
            // который условно кто-то будет вызывать.
            //
            // Разберитесь с инкапсуляцией в этом коде - https://gist.github.com/HolyMonkey/9290ed63c38fc732ed8f58693077095d
            
            Console.WriteLine("Game Start");
            
            Player player = new Player(100);
            
            Weapon weaponBot = new Weapon(20, 20, 3);
            Bot artas = new Bot(weaponBot);

            do
            {
                artas.OnSeeEnemy(player);
            } while (player.IsAlive);

            Console.WriteLine("Game End");
        }
    }
}