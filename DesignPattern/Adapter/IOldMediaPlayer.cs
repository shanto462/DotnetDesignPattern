using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public interface IOldMediaPlayer
    {
        void Play(string mediaType, string fileName);
    }
}
