namespace Task1.Interface
{
    internal interface ICreature : IDamageable
    {
        IHealth Health { get; }
        void OnSeeEnemy(ICreature player);
    }
}