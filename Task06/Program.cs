namespace Task06
{
    internal class Program
    {
        // Используйте более распространённое и простое слово в название метода -
        // https://gist.github.com/HolyMonkey/946002199f327790d8f66e8685a869f3
        
        public static int GetElement(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                    return i;

            return -1;
        }
        
        public static void Main(string[] args)
        {
        }
    }
}