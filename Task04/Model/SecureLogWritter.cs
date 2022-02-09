using Task04.Interface;

namespace Task04.Model
{
    public class SecureLogWritter : LoggerDecorator
    {
        private readonly Day _day;

        public SecureLogWritter(Day day, ILogger logger) : base(logger)
        {
            _day = day;
        }

        public override void WriteError(string message)
        {
            if (_day != null && _day.IsExist())
                base.WriteError(message);
        }
    }
}