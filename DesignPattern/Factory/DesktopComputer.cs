using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class DesktopComputer : IComputer
    {
        public void ShutDown()
        {
            Console.WriteLine("Shutting down my desktop :(");
        }
    }
}
