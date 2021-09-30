using System;
using Task04.Interface;

namespace Task04.Model
{
    class ConsoleLogWritter : LogWritter, ILogger
    {
        public ConsoleLogWritter(LoggerDays loggerDays) : base(loggerDays)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}