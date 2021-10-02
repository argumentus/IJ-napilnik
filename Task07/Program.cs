using System;

namespace Task07
{
    internal class Program
    {
        // Измените код - https://gist.github.com/HolyMonkey/fece8ba4657cb3583ae74949b252d26a
        
        class Weapon
        {
            private readonly int _countBulletsForShoot;
            private int _bullets;

            public Weapon(int countBulletsForShoot)
            {
                _countBulletsForShoot = countBulletsForShoot;
            }

            public bool CanShoot() => _bullets - _countBulletsForShoot > 0;

            public void Shoot()
            {
                if (!CanShoot())
                    throw new ArgumentException(nameof(CanShoot));
                    
                _bullets -= _countBulletsForShoot;
            }
        }
        
        public static void Main(string[] args)
        {
        }
    }
}