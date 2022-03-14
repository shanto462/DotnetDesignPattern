using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    public abstract class BaseGame
    {
        public void Play()
        {
            Move();
            Fire();
            Stop();
        }

        protected abstract void Fire();
        protected abstract void Move();
        protected abstract void Stop();
    }
}
