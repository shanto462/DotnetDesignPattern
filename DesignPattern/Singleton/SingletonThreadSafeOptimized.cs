using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class SingletonThreadsafeOptimized
    {
        private static SingletonThreadsafeOptimized instance = null;
        private static readonly object padlock = new object();
        public static int count = 0;

        SingletonThreadsafeOptimized()
        {
        }

        public static SingletonThreadsafeOptimized Instance
        {
            get
            {
                if (instance is null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadsafeOptimized();
                            Interlocked.Increment(ref count);
                        }
                    }
                }
                return instance;
            }
        }
    }
}
