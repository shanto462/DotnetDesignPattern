using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{

    public enum SongType
    {
        RAP, COUNTRY
    }

    public class SongFactory
    {
        public ISongFactory GetSongFactory(SongType songType)
        {
            return songType == SongType.RAP ? new RapSongFactory() : new CountySongFactory();
        }
    }
}
