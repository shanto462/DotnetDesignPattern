using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public abstract class BaseUser : IUser
    {
        private IChatRoom _chatRoom;

        private readonly string _name;

        public string Name { get => _name; }

        public BaseUser(string name)
        {
            _name = name;
        }

        public void SetChatRoom<T>(T chatroom) where T : IChatRoom
        {
            _chatRoom = chatroom;
        }

        public abstract void Receive(string from, string message);
        public void Send(string to, string message)
        {
            _chatRoom.Send(Name, to, message);
        }
    }
}
