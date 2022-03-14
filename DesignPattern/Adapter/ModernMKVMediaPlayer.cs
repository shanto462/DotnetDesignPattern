using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class ModernMKVMediaPlayer : IModernMediaPlayer
    {
        public void PlayMKV(string fileName)
        {
            Console.WriteLine("Playing MKV");
        }

        public void PlayMP4(string fileName)
        {

        }
    }
}
