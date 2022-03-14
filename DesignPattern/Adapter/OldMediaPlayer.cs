using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class OldMediaPlayer : IOldMediaPlayer
    {
        public void Play(string mediaType, string fileName)
        {
            if (mediaType == "mp3" || mediaType == "wmv")
                Console.WriteLine("Playing");
            else
                throw new Exception("Unknown file format");
        }
    }
}
