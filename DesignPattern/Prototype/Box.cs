using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class Box : ICustomClonable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ICustomClonable CustomClone()
        {
            return new Box
            {
                Width = Width,
                Height = Height
            };
        }
    }
}
