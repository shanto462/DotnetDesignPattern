using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class _90sCountrySong : ISong
    {
        public void Play()
        {
            Console.WriteLine("Playing old country");
        }
    }
}
