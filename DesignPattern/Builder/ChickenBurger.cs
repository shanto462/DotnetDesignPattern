using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class ChickenBurger : Burger
    {
        public override string GetName()
        {
            return "ChickenBurger";
        }

        public override double Price()
        {
            return 100.0f;
        }
    }
}
