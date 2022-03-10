using System;

namespace Task05
{
    internal class Program
    {
        // Переименуйте метод - https://gist.github.com/HolyMonkey/92e8c9c2f08471e31eceef30da7ea6ad
        
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            else
                return value;
        }
        
        public static void Main(string[] args)
        {
        }
    }
}