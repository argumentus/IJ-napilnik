using System.IO;
using Task04.Interface;

namespace Task04.Model
{
    class FileLogWritter : LogWritter, ILogger
    {
        public FileLogWritter(LoggerDays loggerDays) : base(loggerDays)
        {
        }

        protected override void Write(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}