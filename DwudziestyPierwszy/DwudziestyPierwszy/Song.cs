using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwudziestyPierwszy
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public int songID;
        public static int songCount = 0;

        public Song (string title, String artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.songID = songCount;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
