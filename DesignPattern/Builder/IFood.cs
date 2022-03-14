using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public interface IFood
    {
        string GetName();
        IContainer GetContainer();
        double Price();
    }
}
