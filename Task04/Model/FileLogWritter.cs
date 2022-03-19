using System.IO;
using Task04.Interface;

namespace Task04.Model
{
    public class FileLogWritter : LoggerDecorator
    {
        private readonly Day _day;

        public FileLogWritter(Day day, ILogger logger = null) : base(logger)
        {
            _day = day;
        }

        public override void WriteError(string message)
        {
            if (_day != null && _day.IsExist())
                File.WriteAllText("log.txt", message);

            base.WriteError(message);
        }
    }
}