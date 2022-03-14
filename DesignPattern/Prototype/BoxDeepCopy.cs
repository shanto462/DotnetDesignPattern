using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class BoxDeepCopy : ITClonable<BoxDeepCopy>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public CircleDeepCopy CircleDeepCopy { get; set; }

        public BoxDeepCopy DeepCopy()
        {
            return new BoxDeepCopy { Height = Height, Width = Width, CircleDeepCopy = CircleDeepCopy.DeepCopy() };
        }
    }
}
