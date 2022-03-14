using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Wrapper : IContainer
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
