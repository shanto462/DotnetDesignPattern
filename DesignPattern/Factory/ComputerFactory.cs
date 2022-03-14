using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public enum ComputerType
    {
        DESKTOP,
        LAPTOP
    }

    public class ComputerFactory
    {
        public IComputer GetComputer(ComputerType computerType)
        {
            return computerType == ComputerType.DESKTOP ? new DesktopComputer() : new LaptopComputer();
        }
    }
}
