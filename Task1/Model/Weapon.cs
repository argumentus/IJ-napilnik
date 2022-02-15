using System;

namespace Task1.Model
{
    internal class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletPerShot;
        private int _bullets;

        public Weapon(int damage, int bullets, int bulletPerShot)
        {
            _damage = damage;
            _bulletPerShot = bulletPerShot;
            _bullets = bullets;
        }

        public bool CanFire()
        {
            return HasEnoughBulletForFire();
        }

        public void TryFire(Player enemy)
        {
            if (!CanFire())
                throw new ArgumentException(nameof(CanFire));

            enemy.TryDamage(_damage);
            DecreaseBullet(_bulletPerShot);
        }

        private bool HasEnoughBulletForFire()
        {
            return _bullets >= _bulletPerShot;
        }
        
        private void DecreaseBullet(int count)
        {
            if (_bullets < count)
                throw new ArgumentOutOfRangeException(nameof(count));

            _bullets -= count;
        }
    }
}