using System;

namespace Task1.Interface
{
    internal interface IHealth
    {
        int Value { get; }
        bool IsDead { get; }
        event Action<string> OnDie;
    }
}