using System;
using Task04.Interface;

namespace Task04.Model
{
    class Pathfinder : ILogger
    {
        private readonly ILogger _logger;
        
        public Pathfinder(ILogger logger)
        {
            _logger = logger;
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