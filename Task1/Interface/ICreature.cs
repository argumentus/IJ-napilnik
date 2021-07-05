namespace Task1.Interface
{
    internal interface ICreature : IName, IDamageable
    {
        IHealth Health { get; }
        void OnSeeEnemy(ICreature enemy);
    }
}