using System;

namespace Task12
{
    internal class Program
    {
        class Weapon
        {
            public int Damage { get; private set; }
            public float Speed { get; private set; }
            public float Cooldown { get; private set; }

            public Weapon(int damage, float speed, float cooldown)
            {
                Damage = damage;
                Speed = speed;
                Cooldown = cooldown;
            }
        }

        class Movement
        {
            public float X { get; private set; }
            public float Y { get; private set; }

            public Movement(float x, float y)
            {
                X = x;
                Y = y;
            }
        }
        
        class Player
        {
            public string Name { get; private set; }
            public int Age { get; private set; }
            private Weapon _weapon;
            private Movement _movement;

            public Player(string name, int age, Weapon weapon, Movement movement)
            {
                Name = name;
                Age = age;
                _weapon = weapon;
                _movement = movement;
            }

            public void Move()
            {
                //Do move
            }

            public void Attack()
            {
                //attack
            }

            public bool IsReloading()
            {
                throw new NotImplementedException();
            }
        }
        
        public static void Main(string[] args)
        {
        }
    }
}