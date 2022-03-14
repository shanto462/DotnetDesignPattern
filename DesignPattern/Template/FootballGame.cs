using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public class FootballGame : BaseGame
    {
        protected override void Fire()
        {
            Console.WriteLine("Kick ball to goal post");
        }

        protected override void Move()
        {
            Console.WriteLine("Move near goal post");
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop playing football");
        }
    }
}
