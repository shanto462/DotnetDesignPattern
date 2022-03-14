using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class ModernMP4MediaPlayer : IModernMediaPlayer
    {
        public void PlayMKV(string fileName)
        {

        }

        public void PlayMP4(string fileName)
        {
            Console.WriteLine("Playing MP4");
        }
    }
}
