using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public interface IUser
    {
        public string Name { get; }
        public void Receive(string from, string message);
        public void Send(string to, string message);
        public void SetChatRoom<T>(T chatroom) where T : IChatRoom;
    }
}
