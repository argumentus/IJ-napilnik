using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04.Model
{
    public class Day
    {
        public List<DayOfWeek> Days { get; private set; }

        public Day(List<DayOfWeek> days)
        {
            Days = days;
        }

        public bool IsExist()
        {
            return Days.Any(day => day == DateTime.Now.DayOfWeek);
        }
    }
}