using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class MediaAdapter : IOldMediaPlayer
    {
        private IModernMediaPlayer _modernMediaPlayer;

        public MediaAdapter(string mediaType)
        {
            if (mediaType == "mp4")
                _modernMediaPlayer = new ModernMP4MediaPlayer();
            else
                _modernMediaPlayer = new ModernMKVMediaPlayer();
        }

        public void Play(string mediaType, string fileName)
        {
            if (mediaType == "mp4")
                _modernMediaPlayer.PlayMP4(fileName);
            else
                _modernMediaPlayer.PlayMKV(fileName);
        }
    }
}
