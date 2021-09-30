using System;
using System.Collections.Generic;
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
            List<DayOfWeek> allDays = new List<DayOfWeek>();
            allDays.Add(DayOfWeek.Sunday);
            allDays.Add(DayOfWeek.Monday);
            allDays.Add(DayOfWeek.Tuesday);
            allDays.Add(DayOfWeek.Wednesday);
            allDays.Add(DayOfWeek.Thursday);
            allDays.Add(DayOfWeek.Friday);
            allDays.Add(DayOfWeek.Saturday);
            
            List<DayOfWeek> fridayDays = new List<DayOfWeek>();
            fridayDays.Add(DayOfWeek.Friday);
            
            
            Pathfinder logger1 = new Pathfinder(new FileLogWritter(new LoggerDays(allDays)));
            logger1.WriteError("Logger1.");
            
            Pathfinder logger2 = new Pathfinder(new ConsoleLogWritter(new LoggerDays(allDays)));
            logger2.WriteError("Logger2.");
            
            Pathfinder logger3 = new Pathfinder(new FileLogWritter(new LoggerDays(fridayDays)));
            logger3.WriteError("Logger3.");
            
            Pathfinder logger4 = new Pathfinder(new ConsoleLogWritter(new LoggerDays(fridayDays)));
            logger4.WriteError("Logger4.");
            
            Pathfinder logger5 = new Pathfinder(new ConsoleLogWritter(new LoggerDays(allDays))
                , new FileLogWritter(new LoggerDays(fridayDays)));
            logger5.WriteError("Logger5.");

        }
    }
}