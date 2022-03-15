using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{

    public interface IMementoHandler
    {
        void Save(SaveType saveType);
        void Undo();
        void Redo();
    }
}
