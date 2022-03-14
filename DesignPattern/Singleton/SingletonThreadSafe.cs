using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object _padlock = new object();
        public static int count = 0;

        private SingletonThreadSafe()
        {
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                        Interlocked.Increment(ref count);
                    }
                    return instance;
                }
            }
        }
    }
}
