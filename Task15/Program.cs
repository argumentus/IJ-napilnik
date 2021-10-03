namespace Task15
{
    internal class Program
    {
        // Попробуйте заменить метод на пару Включить\Выключить
        // - https://gist.github.com/HolyMonkey/ef0c234f158151d80ecb22d3717c9ac2
        
        public void Enable()
        {
            _effects.StartEnableAnimation();
        }
        
        public void Disable()
        {
            _pool.Free(this);
        }
        
        public static void Main(string[] args)
        {
        }
    }
}