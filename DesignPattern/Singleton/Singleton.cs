using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;

        public static int count = 0;

        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new Singleton();
                    Interlocked.Increment(ref count);
                }
                return instance;
            }
        }
    }
}
