using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class AdaptedMediaPlayer : IOldMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string mediaType, string fileName)
        {
            if (mediaType == "mp3" || mediaType == "wmv")
            {
                Console.WriteLine("Playing old types");
            }
            else if (mediaType == "mp4" || mediaType == "mkv")
            {
                _mediaAdapter = new MediaAdapter(mediaType);
                _mediaAdapter.Play(mediaType, fileName);
            }
            else
            {
                Console.WriteLine("Unknown format!");
            }
        }
    }
}
