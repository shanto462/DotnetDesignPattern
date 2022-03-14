using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() => new SingletonLazy(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static SingletonLazy Instance { get { return lazy.Value; } }

        private SingletonLazy()
        {
        }
    }
}
