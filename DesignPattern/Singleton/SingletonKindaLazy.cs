using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class SingletonKindaLazy
    {
        private static readonly SingletonKindaLazy instance = new SingletonKindaLazy();

        static SingletonKindaLazy()
        {
        }

        private SingletonKindaLazy()
        {
        }

        public static SingletonKindaLazy Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
