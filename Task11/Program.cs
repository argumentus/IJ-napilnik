using System;

namespace Task11
{
    internal class Program
    {
        public static void CreateObject()
        {
            //Создание объекта на карте
        }

        public static void RandomizeChance()
        {
            _chance = Random.Range(0, 100);
        }

        public static int CalculateSalary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
        
        public static void Main(string[] args)
        {
        }
    }
}