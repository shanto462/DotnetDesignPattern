using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public abstract class ColdDrink : IFood
    {
        public IContainer GetContainer()
        {
            return new Bottle();
        }

        public abstract string GetName();
        public abstract double Price();
    }
}
