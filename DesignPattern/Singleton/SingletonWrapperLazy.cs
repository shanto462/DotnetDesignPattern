using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class SingletonWrapperLazy
    {
        private SingletonWrapperLazy()
        {
        }

        public static SingletonWrapperLazy Instance { get { return SingletonInner.instance; } }

        private class SingletonInner
        {
            static SingletonInner()
            {
            }

            internal static readonly SingletonWrapperLazy instance = new SingletonWrapperLazy();
        }
    }
}
