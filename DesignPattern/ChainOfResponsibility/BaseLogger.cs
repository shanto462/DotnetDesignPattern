using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public enum LogType
    {
        CONSOLE,
        FILE,
        DB
    }


    public abstract class BaseLogger
    {
        public BaseLogger NextLogger { get; set; }

        public LogType Type { get; set; }

        public BaseLogger(LogType logType, BaseLogger nextLogger)
        {
            Type = logType;
            NextLogger = nextLogger;
        }

        protected abstract void LogBehaviour(string message);

        public void Log(string message, LogType logType)
        {
            if (logType == Type)
            {
                LogBehaviour(message);
            }
            else
            {
                if (NextLogger is not null)
                    NextLogger.Log(message, logType);
                else
                    Console.WriteLine("Unknown log type");
            }
        }
    }
}
