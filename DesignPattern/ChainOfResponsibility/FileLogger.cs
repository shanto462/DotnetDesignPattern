using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class FileLogger : BaseLogger
    {
        public FileLogger(LogType logType, BaseLogger nextLogger) : base(logType, nextLogger)
        {
        }

        protected override void LogBehaviour(string message)
        {
            Console.WriteLine($"Writing {message} to File");
        }
    }
}
