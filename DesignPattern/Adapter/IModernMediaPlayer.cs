using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public interface IModernMediaPlayer
    {
        void PlayMP4(string fileName);
        void PlayMKV(string fileName);
    }
}
