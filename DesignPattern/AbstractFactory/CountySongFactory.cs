using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class CountySongFactory : ISongFactory
    {
        public ISong GetSong(SongTimePeriod songType)
        {
            return songType == SongTimePeriod._90S ? new _90sCountrySong() : new CountrySong();
        }
    }
}
