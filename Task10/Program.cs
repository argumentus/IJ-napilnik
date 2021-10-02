using System.Collections.Generic;

namespace Task10
{
    internal class Program
    {
        // Переименуйте классы - https://gist.github.com/HolyMonkey/301475a9d6ec900584a254cee3485673
        
        class Player { }
        class Gun { }
        class Target { }
        class Unit
        {
            public IReadOnlyCollection<Unit> List {get; private set;}
        }
        
        public static void Main(string[] args)
        {
        }
    }
}