using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletPerShot;
        private readonly int _bullets;

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
        
        public void TryFire(ICreature enemy)
        {
            if (!CanFire())
                throw new ArgumentException(nameof(CanFire));

            enemy.Damage(_damage);
        }

        private bool HasEnoughBulletForFire()
        {
            return _bullets >= _bulletPerShot;
        }
        
    }
}