using System;
using Task04.Interface;

namespace Task04.Model
{
    class ConsoleLogWritter : LogWritter, ILogger
    {
        private readonly ILogger _logger;
        
        public ConsoleLogWritter(LoggerDays loggerDays, ILogger logger = null) : base(loggerDays)
        {
            _logger = logger;
        }

        protected override void Write(string message)
        {
            if (_logger != null)
                _logger.WriteError(message);
                
            Console.WriteLine(message);
        }
    }
}