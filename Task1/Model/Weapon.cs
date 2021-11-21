using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletsCountDefault;
        private readonly int _bulletPerShot;
        private int _bullets;

        public Weapon(int damage, int bullets, int bulletPerShot)
        {
            _damage = damage;
            _bulletsCountDefault = bullets;
            _bulletPerShot = bulletPerShot;
            _bullets = bullets;
        }

        public bool CanFire()
        {
            return HasEnoughBulletForFire();
        }
        
        public void TryFire(IDamageable enemy, int damage)
        {
            if (damage < 0)
                damage = 0;

            if (!CanFire())
                throw new ArgumentException(nameof(CanFire));
            
            DecreaseBullet(_bulletPerShot);

            enemy.TryDamage(_damage + damage);
        }

        public void Reload()
        {
            _bullets = _bulletsCountDefault;
        }
        
        private bool HasEnoughBulletForFire()
        {
            return _bullets >= _bulletPerShot;
        }
        
        private void DecreaseBullet(int count)
        {
            if (_bulletsCountDefault < count)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_bullets - count < 0)
                Reload();
            else
                _bullets -= count;
            // TODO: Замечание: В общем стрелять мы можем сразу тремя обоймами
        }
    }
}