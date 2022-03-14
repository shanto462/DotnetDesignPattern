using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Pepsi : ColdDrink
    {
        public override string GetName()
        {
            return "Pepsi";
        }

        public override double Price()
        {
            return 100.0f;
        }
    }
}
