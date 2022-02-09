using Task04.Interface;

namespace Task04.Model
{
    public abstract class LoggerDecorator : ILogger
    {
        private readonly ILogger _logger;

        protected LoggerDecorator(ILogger logger) => _logger = logger;

        public virtual void WriteError(string message)
        {
            _logger?.WriteError(message);
        }
    }
}