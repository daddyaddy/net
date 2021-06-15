using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flangery_net
{
    public class PlaylistModel
    {
        public SongModel[] songs { get; set; }
        public int currentSongIdx { get; set; }
    }
}
