using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class Logger
    {
        private static readonly Lazy<Logger> _logger = new Lazy<Logger>((() => new Logger()));

        private static Logger Instance => _logger.Value;

        private BaseLogger _rootLogger;

        private Logger()
        {
            var fileLogger = new FileLogger(LogType.FILE, null);
            _rootLogger = new ConsoleLogger(LogType.CONSOLE, fileLogger);
        }

        public static void Log(string message, LogType logType)
        {
            Instance._rootLogger.Log(message, logType);
        }
    }
}
