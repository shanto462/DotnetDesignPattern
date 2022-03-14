using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Coke : ColdDrink
    {
        public override string GetName()
        {
            return "Coke";
        }

        public override double Price()
        {
            return 1000.0f;
        }
    }
}
