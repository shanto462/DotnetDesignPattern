using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class BoxMemberWise : ICloneable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Circle Circle { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
