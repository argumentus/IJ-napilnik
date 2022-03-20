using System;

namespace Task1.Model
{
    internal class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletPerShot;
        private int _bullets;

        public Weapon(int damage, int bullets, int bulletPerShot) =>
            (_damage, _bulletPerShot, _bullets) = (damage, bulletPerShot, bullets);

        public bool HasEnoughBulletForFire => _bullets >= _bulletPerShot;

        public void Damage(Player enemy)
        {
            if (!HasEnoughBulletForFire)
                throw new ArgumentException(nameof(HasEnoughBulletForFire));

            enemy.Damage(_damage);
            _bullets -= _bulletPerShot;
        }
    }
}