using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public enum SongTimePeriod
    {
        _90S,
        Modern
    }

    public interface ISongFactory
    {
        ISong GetSong(SongTimePeriod songType);
    }
}
