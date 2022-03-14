using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class CountrySong : ISong
    {
        public void Play()
        {
            Console.WriteLine("Playing new country");
        }
    }
}
