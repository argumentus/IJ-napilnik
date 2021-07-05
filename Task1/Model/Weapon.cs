using System;
using Task1.Interface;

namespace Task1.Model
{
    internal class Weapon
    {
        private readonly float _damage;
        private readonly int _bulletsCountDefault;
        private readonly int _bulletPerShot;
        private int _bullets;

        public Weapon(float damage, int bullets, int bulletPerShot)
        {
            _damage = damage;
            _bulletsCountDefault = bullets;
            _bulletPerShot = bulletPerShot;
            _bullets = bullets;
        }

        public void TryFire(IDamageable enemy, float damage)
        {
            if (damage < 0f)
                damage = 0f;

            DecreaseBullet(_bulletPerShot);

            enemy.TryDamage(_damage + damage);
        }

        private void DecreaseBullet(int count)
        {
            if (_bulletsCountDefault - count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if (_bullets - count < 0)
                Reload();
            else
                _bullets -= count;
        }

        public void Reload()
        {
            _bullets = _bulletsCountDefault;
        }
    }
}