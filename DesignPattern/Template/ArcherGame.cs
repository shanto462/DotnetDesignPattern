using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public class ArcherGame : BaseGame
    {
        protected override void Fire()
        {
            Console.WriteLine("Fire to the point");
        }

        protected override void Move()
        {
            Console.WriteLine("Move to the spot");
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop playing");
        }
    }
}
