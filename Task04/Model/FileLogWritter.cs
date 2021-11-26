using System.IO;
using Task04.Interface;

namespace Task04.Model
{
    class FileLogWritter : LogWritter, ILogger
    {
        private readonly ILogger _logger;
        
        public FileLogWritter(LoggerDays loggerDays, ILogger logger = null) : base(loggerDays)
        {
            _logger = logger;
        }

        protected override void Write(string message)
        {
            if (_logger != null)
                _logger.WriteError(message);
            
            File.WriteAllText("log.txt", message);
        }
    }
}