using System;

namespace Task07
{
    internal class Program
    {
        // Измените код - https://gist.github.com/HolyMonkey/fece8ba4657cb3583ae74949b252d26a
        
        class Weapon
        {
            private readonly int _countBulletsPerShoot;
            private int _bullets;
            
            public Weapon(int countBulletsPerShoot)
            {
                _countBulletsPerShoot = countBulletsPerShoot;
            }

            public bool CanShoot() => _bullets >= _countBulletsPerShoot;

            public void Shoot() => _bullets -= _countBulletsPerShoot;
        }
        
        public static void Main(string[] args)
        {
        }
    }
}