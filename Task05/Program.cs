using System;

namespace Task05
{
    internal class Program
    {
        // Переименуйте метод - https://gist.github.com/HolyMonkey/92e8c9c2f08471e31eceef30da7ea6ad
        
        public static int ComparisonNumber(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
        
        public static void Main(string[] args)
        {
        }
    }
}