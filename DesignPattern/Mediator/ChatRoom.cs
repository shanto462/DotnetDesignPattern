using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, IUser> _users = new Dictionary<string, IUser>();

        public void Register(IUser user)
        {
            if (!_users.ContainsValue(user))
            {
                _users[user.Name] = user;
            }
            user.SetChatRoom(this);
        }

        public void Send(string from, string to, string message)
        {
            IUser user = _users[to];
            if (user != null)
            {
                user.Receive(from, message);
            }
        }
    }
}
