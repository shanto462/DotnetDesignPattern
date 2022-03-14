using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public abstract class Burger : IFood
    {
        public IContainer GetContainer()
        {
            return new Wrapper();
        }

        public abstract string GetName();
        public abstract double Price();
    }
}
