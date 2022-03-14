using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class VegBurger : Burger
    {
        public override string GetName()
        {
            return "VegBurger";
        }

        public override double Price()
        {
            return 1000.0f;
        }
    }
}
