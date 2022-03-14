using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class CircleDeepCopy : ITClonable<CircleDeepCopy>
    {
        public int Radius { get; set; }

        public CircleDeepCopy DeepCopy()
        {
            return new CircleDeepCopy { Radius = 10 };
        }
    }
}
