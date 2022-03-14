using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Bottle : IContainer
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
