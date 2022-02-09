using System;
using System.Collections.Generic;
using Task04.Interface;

namespace Task04.Model
{
    public class Pathfinder : ILogger
    {
        private readonly ILogger _logger;

        public Pathfinder()
        {
            List<DayOfWeek> days = new List<DayOfWeek> { DayOfWeek.Friday };
            Day day = new Day(days);
            _logger = new SecureLogWritter(day, new ConsoleLogWritter(day));
        }

        public void WriteError(string message)
        {
            Find(message);
        }

        private void Find(string message)
        {
            _logger.WriteError(message);
        }
    }
}