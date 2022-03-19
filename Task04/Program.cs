using System;
using System.Collections.Generic;
using Task04.Interface;
using Task04.Model;

namespace Task04
{
    // Есть такая реализация логирования - https://pastebin.com/7xL6S4vV
    //
    // Защищённый логер даёт функционал, что логер пишется только по пятницам (такая условность).
    //
    // Представьте класс Pathfinder у которого есть зависимость от условного ILogger, в процессе своей работы
    // он что-то пишет в лог. Что не принципиально. Сделайте в нём один метод Find который только пишет в лог
    // через своего логера.
    //
    // Перепроектируйте систему логирования так, что бы у меня было 5 объектов класса Pathfinder.
    // 1) Пишет лог в файл. 2) Пишет лог в консоль. 3) Пишет лог в файл по пятницам. 4) Пишет лог в консоль по пятницам.
    // 5) Пишет лог в консоль а по пятницам ещё и в файл.


    internal class Program
    {
        public static void Main(string[] args)
        {
            List<DayOfWeek> allDays = new List<DayOfWeek>
            {
                DayOfWeek.Sunday,
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
            };
            List<DayOfWeek> fridayDays = new List<DayOfWeek> { DayOfWeek.Friday };
            Day allDay = new Day(allDays);
            Day fridayDay = new Day(fridayDays);

            ILogger logger1 = new FileLogWritter(allDay, new Pathfinder());
            logger1.WriteError("Logger1.");

            ILogger logger2 = new ConsoleLogWritter(allDay, new Pathfinder());
            logger2.WriteError("Logger2.");

            ILogger logger3 = new FileLogWritter(fridayDay, new Pathfinder());
            logger3.WriteError("Logger3.");

            ILogger logger4 = new ConsoleLogWritter(fridayDay, new Pathfinder());
            logger4.WriteError("Logger4.");

            ILogger logger5 = new ConsoleLogWritter(allDay, new FileLogWritter(fridayDay, new Pathfinder()));
            logger5.WriteError("Logger5.");
        }
    }
}