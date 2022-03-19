using System;
using Task04.Interface;

namespace Task04.Model
{
    public class ConsoleLogWritter : LoggerDecorator
    {
        private readonly Day _day;

        public ConsoleLogWritter(Day day = null, ILogger logger = null) : base(logger)
        {
            _day = day;
        }

        public override void WriteError(string message)
        {
            if (_day != null && _day.IsExist())
                Console.WriteLine(message);

            base.WriteError(message);
        }
    }
}