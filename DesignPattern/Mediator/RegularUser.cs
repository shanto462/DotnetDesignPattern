using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public class RegularUser : BaseUser
    {
        public RegularUser(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"Received \\{message}\\ from \\{from}\\ :)");
        }
    }
}
