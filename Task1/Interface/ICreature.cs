namespace Task1.Interface
{
    public interface ICreature
    {
        int Health { get; }
        bool IsAlive { get; }
        
        void TryDamage(int damage);
    }
}