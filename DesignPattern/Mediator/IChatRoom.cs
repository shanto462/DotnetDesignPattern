using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public interface IChatRoom
    {
        void Register(IUser user);
        void Send(string from, string to, string message);
    }
}
