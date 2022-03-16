using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
