using Task1.Interface;

namespace Task1.Model
{
    internal class NormalDyingPolicy : IDyingPolicy
    {
        public bool IsDead(int health)
        {
            return health <= 0;
        }
    }
}