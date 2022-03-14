using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class Circle : ICustomClonable
    {
        public int Radius { get; set; }
        public ICustomClonable CustomClone()
        {
            return new Circle { Radius = Radius };
        }
    }
}
