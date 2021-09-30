using System;
using System.Linq;

namespace Task04.Model
{
    abstract class LogWritter
    {
        private readonly LoggerDays _loggerDays;

        public LogWritter(LoggerDays loggerDays)
        {
            _loggerDays = loggerDays;
        }
        
        public void WriteError(string message)
        {
            bool isExist = _loggerDays.Days.Any(day => day == DateTime.Now.DayOfWeek);

            if (isExist)
                Write(message);
        }

        protected abstract void Write(string message);
    }
}