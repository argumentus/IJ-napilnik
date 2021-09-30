using System;
using System.Collections.Generic;

namespace Task04.Model
{
    public class LoggerDays
    {
        public List<DayOfWeek> Days { get; private set; }

        public LoggerDays(List<DayOfWeek> days)
        {
            Days = days;
        }
    }
}