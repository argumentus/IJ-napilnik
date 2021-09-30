using System;
using Task04.Interface;

namespace Task04.Model
{
    class Pathfinder : ILogger
    {
        private readonly Array _loggers;
        
        public Pathfinder(params ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            Find(message);
        }

        private void Find(string message)
        {
            foreach (ILogger logger in _loggers)
            {
                logger.WriteError(message);
            }
        }
    }
}